/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2016 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Dev2.Common;
using Dev2.Common.Interfaces.Core.DynamicServices;
using Dev2.Common.Interfaces.Hosting;
using Dev2.Communication;
using Dev2.DynamicServices;
using Dev2.DynamicServices.Objects;
using Dev2.Runtime.Exceptions;
using Dev2.Runtime.Hosting;
using Dev2.Workspaces;

namespace Dev2.Runtime.ESB.Management.Services
{
    /// <summary>
    /// Delete a resource ;)
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class DeleteResource : IEsbManagementEndpoint
    {
        private readonly IAuthorizer _authorizer;
        public DeleteResource(IAuthorizer authorizer)
        {
            _authorizer = authorizer;
        }

        // ReSharper disable once MemberCanBeInternal
        public DeleteResource()
            :this(new SecuredContributeManagementEndpoint())
        {

        }
        public StringBuilder Execute(Dictionary<string, StringBuilder> values, IWorkspace theWorkspace)
        {
            Dev2JsonSerializer serializer = new Dev2JsonSerializer();
            try
            {
                string type = null;
              
                StringBuilder tmp;
                values.TryGetValue("ResourceID", out tmp);
                Guid resourceId = Guid.Empty;
                if (tmp != null)
                {
                    if (!Guid.TryParse(tmp.ToString(), out resourceId))
                    {
                        Dev2Logger.Info("Delete Resource Service. Invalid Parameter Guid:");
                        var failureResult = new ExecuteMessage { HasError = true };
                        failureResult.SetMessage("Invalid guid passed for ResourceID");
                        return serializer.SerializeToBuilder(failureResult);
                    }
                }
                values.TryGetValue("ResourceType", out tmp);
                if (tmp != null)
                {
                    type = tmp.ToString();
                }
                _authorizer.RunPermissions(resourceId);
                Dev2Logger.Info("Delete Resource Service. Resource:" + resourceId);
                // BUG 7850 - TWR - 2013.03.11 - ResourceCatalog refactor
                var msg = ResourceCatalog.Instance.DeleteResource(theWorkspace.ID, resourceId, type);
                TestCatalog.Instance.DeleteAllTests(resourceId);
                TestCatalog.Instance.Load();
                var result = new ExecuteMessage { HasError = false };
                result.SetMessage(msg.Message);
                result.HasError = msg.Status != ExecStatus.Success;
                return serializer.SerializeToBuilder(result);
            }
            catch(ServiceNotAuthorizedException ex)
            {
                var result = new ExecuteMessage { HasError = true };
                result.SetMessage(ex.Message);
                return serializer.SerializeToBuilder(result);
            }
        }

        public string HandlesType()
        {
            return "DeleteResourceService";
        }

        public DynamicService CreateServiceEntry()
        {
            var deleteResourceService = new DynamicService
            {
                Name = HandlesType(),
                DataListSpecification = new StringBuilder("<DataList><ResourceName ColumnIODirection=\"Input\"/><ResourceType ColumnIODirection=\"Input\"/><Roles ColumnIODirection=\"Input\"/><Dev2System.ManagmentServicePayload ColumnIODirection=\"Both\"></Dev2System.ManagmentServicePayload></DataList>")
            };

            var deleteResourceAction = new ServiceAction
            {
                Name = HandlesType(),
                ActionType = enActionType.InvokeManagementDynamicService,
                SourceMethod = HandlesType()
            };

            deleteResourceService.Actions.Add(deleteResourceAction);

            return deleteResourceService;
        }
    }
}
