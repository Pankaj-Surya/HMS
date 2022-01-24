using HMS.Data;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services
{
    public class AccomodationTypesService
    {

        //LIST VS IEnumerable
        //performance wise IEnumerbale good
        public IEnumerable<AccomodationType> GetAllAccomodationTypes()
        {
            var context = new HMSContext();

            return context.AccomodationTypes.ToList();
        }


    }
}
