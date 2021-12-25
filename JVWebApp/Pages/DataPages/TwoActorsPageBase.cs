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

        public string ChosenActorToCompareWith1 { get; set; }
        public string ChosenActorToCompareWith2 { get; set; }

        [Inject]
        public IShowAppearanceData _db { get; set; }
        [Inject]
        public IActorData _actorDB { get; set; }
        [Inject]
        public IProductionData _prodDB { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public List<ShowAppearanceModel> showAppearances { get; set; }
        public List<string> imageURLs { get; set; }
        public ActorModel Actor1 { get; set; }
        public ActorModel Actor2 { get; set; }

        public List<SearchActorToCompareModel> searchActorToCompareModels { get; set; }

        public int CountShows()
        {
            int output = 0;

            foreach (var item in showAppearances)
            {
                output += item.NumberOfShows;
            }

            return output / 2;
        }

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
                searchActorToCompareModels = await _actorDB.GetAllActors();

                var prodID = showAppearances.Select(show => show.ProductionID).Distinct().ToList();
                await GetImageURLs(prodID);
                ChosenActorToCompareWith1 = Actor1.ActorID.ToString();
                ChosenActorToCompareWith2 = Actor2.ActorID.ToString();

            }
            catch
            {

            }
        }

        private async Task GetImageURLs(List<int> prodID)
        {
            imageURLs = new List<string>();
            foreach (var item in prodID)
            {
                var temp = await _prodDB.GetImageOnProductionID(item);
                imageURLs.Add(temp.PictureURL);
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            await SetData();
            StateHasChanged();
        }

        public void SubmitActorComparison()
        {
            NavigationManager.NavigateTo($"/People/{ChosenActorToCompareWith1}/{ChosenActorToCompareWith2}");
        }

    }
}
