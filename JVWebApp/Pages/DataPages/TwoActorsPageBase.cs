using JVDataAccess;
using JVDataAccess.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JVWebApp.Pages.DataPages
{
    public class TwoActorsPageBase : ComponentBase
    {
        [Parameter]
        public string ID { get; set; }
        [Parameter]
        public string ID2 { get; set; }

        [Inject]
        public IShowAppearanceData _db { get; set; }
        [Inject]
        public IActorData _actorDB { get; set; }

        public List<ShowAppearanceModel> showAppearances { get; set; }
        public ActorModel Actor1 { get; set; }
        public ActorModel Actor2 { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await SetData();
        }

        public async Task SetData()
        {
            try
            {

                int id = int.Parse(ID);
                int id2 = int.Parse(ID2);
                showAppearances = await _db.GetTwoActorsAppearances(id, id2);
                Actor1 = await _actorDB.GetActor(id);
                Actor2 = await _actorDB.GetActor(id2);

            }
            catch (Exception)
            {

            }
        }

        protected override async Task OnParametersSetAsync()
        {
            await SetData();
            StateHasChanged();
        }

    }
}
