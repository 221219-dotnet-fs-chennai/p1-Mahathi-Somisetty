﻿using System;
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

        Details Update(Details trainerdata);

        bool Login(string email);
        //bool Login(string? emailId);
    }
}
