using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateDraft))]
    public partial interface IStateDraft 
    {
        string Key { get; set;}
        
        string Type { get; set;}
        
        StateTypeEnum TypeAsEnum { get; }
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        bool? Initial { get; set;}
        
        List<string> Roles { get; set;}
        
        List<StateRoleEnum> RolesAsEnum { get; }
        
        List<IStateResourceIdentifier> Transitions { get; set;}
    }
}
