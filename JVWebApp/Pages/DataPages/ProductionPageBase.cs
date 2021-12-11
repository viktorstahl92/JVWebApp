using JVDataAccess;
using JVDataAccess.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JVWebApp.Pages.DataPages
{
    public class ProductionPageBase : ComponentBase
    {
        [Parameter]
        public string ID { get; set; }

        [Inject]
        public IProductionData _db { get; set; }
        [Inject]
        public ICastData _dbCastData { get; set; }

        [Inject]
        public ITrackData _dbTrackData { get; set; }

        [Inject]
        public IProductionImageData _dbImageData { get; set; }

        public List<ProductionModel> Productions { get; set; }
        public List<CastModel> Cast { get; set; }

        public List<CastModel> CreativeTeam { get; set; }

        //public List<TrackModel> Tracks { get; set; }

        public ProductionImageModel ImageModel { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                int sendThis = int.Parse(ID);

                Productions = await _db.GetProductionInfoOnID(sendThis);
                CreativeTeam = await _dbCastData.GetAllCreativeInProduction(Productions[0].ProductionID);
                Cast = await _dbCastData.GetAllActorsInProduction(Productions[0].ProductionID);
                //Tracks = await _dbTrackData.GetSongsFromProductionToVS(Productions[0].ProductionID);
                ImageModel = await _dbImageData.GetImageOnProductionID(Productions[0].ProductionID);
            }
            catch (Exception)
            {
            }

        }


    }
}
