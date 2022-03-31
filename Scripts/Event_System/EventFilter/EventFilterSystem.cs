using UnityEngine;
using StrangeWorld.Tools;
using StrangeWorld.Entities;
using StrangeWorld.Collections;

namespace StrangeWorld.Events.EventFilters
{
    //* System used to filtrate events using filter conditions on components data
    //* T = AEventFilterComponent
    //* T2 = FilterData
    //* T3 = EventFilterArgs
    [CreateAssetMenu(fileName = "New_Filter_System", menuName = "SW/Systems/Filter_System")]
    public class EventFilterSystem : AEventSystem<AEventFilterComponent, EventFilterData, EventFilterArgs>
    {
        //Methods        
        //Override to check filters and raise responses 
        protected override void OnEventRaise(object sender, EventFilterArgs args)
        {
            //Check if can make checks
            bool hasSafeReferences = args.data != null && args.entity != null;

            //Avoid empty data
            if (hasSafeReferences)
            {
                //Entity references
                GameObject entity = args.entity;
                //Try to get component
                entity.TryGetComponent<ScriptableEnumComponent>(out ScriptableEnumComponent component);
                ScriptableEnumComponent enumComponent = component ? component : null;
                bool canInvokeResponses = false;

                //Itinerate data and check filters
                foreach (var argsData in args.data)
                {
                    //Data profile
                    EventFilterProfile profile = argsData.Profile;

                    //Local method
                    //Itinerate data scripotable enums and check with entity enums
                    bool HasEntityEnum()
                    {
                        bool returnValue = false;

                        //Avoid missing component
                        if (enumComponent != null)
                        {
                            //Avoid missing references
                            if (enumComponent.Data != null)
                                //Itinerate component data
                                foreach (var enumData in enumComponent.Data)
                                    //Check if its the correct enum
                                    if (CollectionsTools.HasArrayObject(profile.ScriptableEnums, enumData.ScriptableEnum))
                                    {
                                        returnValue = true;
                                        break;
                                    }
                                    else ReferencesTools.DebugMissingReference();
                        }

                        return returnValue;
                    }

                    //Check filters
                    bool passLayerFilter = profile.Layers.Length == 0 || CollectionsTools.HasArrayObject(profile.Layers, entity.layer),
                    passTagFilter = profile.Tags.Length == 0 || CollectionsTools.HasArrayObject(profile.Tags, entity.tag),
                    passEntityFilter = argsData.Entities.Length == 0 || CollectionsTools.HasArrayObject(argsData.Entities, entity),
                    passEnumFilter = profile.ScriptableEnums.Length == 0 || HasEntityEnum();

                    //Set if can invoke response
                    if (passLayerFilter && passTagFilter && passEntityFilter && passEnumFilter)
                    {
                        canInvokeResponses = true;
                        break;
                    }
                }

                //Check if can invoke
                if (canInvokeResponses) base.OnEventRaise(sender, args);
            }
            else ReferencesTools.DebugMissingReference();
        }
    }
}