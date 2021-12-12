using JVDataAccess;
using JVDataAccess.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JVWebApp.Pages.DataPages
{
    public class ActorPageBase : ComponentBase
    {

        [Parameter]
        public string ID { get; set; }

        [Inject]
        public IActorData _db { get; set; }
        [Inject]
        public IShowAppearanceData _db2 { get; set; }
        [Inject]
        public ILatestThreeShowsData _db3 { get; set; }
        public ActorModel Actor { get; set; }
        public List<ShowAppearanceModel> showAppearanceModels { get; set; }
        public List<ShowAppearanceModel> creativeShowAppearanceModels { get; set; }

        public List<LatestThreeShowsModel> latestThreeShowsModels { get; set; }

        protected async override Task OnInitializedAsync()
        {
            
            try
            {
                int sendThis = int.Parse(ID);
                Actor = await _db.GetActor(sendThis);
                if (Actor is null)
                    return;

                showAppearanceModels = await _db2.GetShowAppearances(Actor.ActorID);
                creativeShowAppearanceModels = await _db2.GetShowAppearancesCreative(Actor.ActorID);
                latestThreeShowsModels = await _db3.GetProductionInfoOnID(Actor.ActorID);
            }
            catch (Exception)
            {

                
            }

        }

    }
}
