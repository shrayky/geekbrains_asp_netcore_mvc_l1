﻿using System;

namespace WebStore.Models
{
    public class EmployeeViewModel
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set;}

    }
}
