﻿using System;
using Prototype.Domain.Aggregates.Patient.Events;

namespace Prototype.Domain.Aggregates.Patient
{
    public class PatientState
    {
        public String Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Int32 Level { get; set; }

        public void On(PatientCreated e)
        {
            Id = e.Id;
            DateOfBirth = e.DateOfBirth;
            Level = e.Level;
        }

        public void On(PatientUpdated e)
        {
            Id = e.Id;
            DateOfBirth = e.DateOfBirth;
            Level = e.Level;
        }
    }
}