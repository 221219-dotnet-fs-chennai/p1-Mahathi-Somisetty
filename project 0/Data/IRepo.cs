using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal interface IRepo
    {
        Details Add(Details trainerdata);

        //List<Details> Trainer_Data();

        //List<Details> GetTrainerDisconnected();

        //bool Login(string email);
    }
}
