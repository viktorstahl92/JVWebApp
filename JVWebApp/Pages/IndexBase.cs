using JVDataAccess;
using JVDataAccess.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JVWebApp.Pages
{
    public class IndexBase : ComponentBase
    {
        public SearchModel searchModel = new SearchModel();

        public List<ActorModel> searchedActors;
        public List<ShowModel> searchedShows;
        public List<ProductionModel> randomProds;
        [Inject]
        public IActorData _db { get; set; }

        [Inject]
        public IShowData _db2 { get; set; }

        [Inject]
        public IProductionData _dbProductions { get; set; }

        public async Task SearchForItem() => searchedActors = await _db.SearchActor(searchModel.SearchQuery);
        public async Task SearchForShows() => searchedShows = await _db2.SearchShow(searchModel.SearchQuery);

        public async Task GetRandomProductions() => randomProds = await _dbProductions.GetRandomProduction();

        public async Task Search()
        {
            await SearchForItem();
            await SearchForShows();

        }

        protected async override Task OnInitializedAsync()
        {
            await GetRandomProductions();
        }
    }
}
