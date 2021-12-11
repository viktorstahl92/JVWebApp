using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JVDataAccess;
using JVDataAccess.Models;

namespace JVWebApp.Pages.DataPages
{
    public class ShowPageBase : ComponentBase
    {
        [Parameter]
        public string ID { get; set; }

        [Inject]
        public IProductionData productionDB { get; set; }
        [Inject]
        public IShowData showDB { get; set; }

        public ShowModel Show;
        public List<ProductionModel> Productions;

        protected async override Task OnInitializedAsync()
        {
            try
            {
                int sendthis = int.Parse(ID);
                Show = await showDB.GetShowOnID(sendthis);
                Productions = await productionDB.GetProductionInfoOnShowID(sendthis);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
