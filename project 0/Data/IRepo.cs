using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepo
    {
        Details Add(Details trainerdata);

        //List<Details> Trainer_Data();

        //List<Details> GetTrainerDisconnected();
        Details Get(string email);

        void Tupdate(string TableName, string ColoumnName, string Newvalue, string TraineeId );
        void TDelete(string TableName, string ColoumnName, string TraineeId);

        bool Login(string email);
        //bool Login(string? emailId);
    }
}
