﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Start.Models
{

    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }

        public List<Order> Orders { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }

        public Item Item { get; set; }
        public Customer Customer { get; set; }

        public double TotalPaid { get; set; }
    }
    public class Company
  {
    [Key]
    public string symbol { get; set; }
    public string name { get; set; }
    public string date { get; set; }
    public bool isEnabled { get; set; }
    public string type { get; set; }
    public string iexId { get; set; }
    public List<Quote> Quotes { get; set; }
  }

  public class Quote
  {
    public int QuoteId { get; set; }
    public string date { get; set; }
    public float open { get; set; }
    public float high { get; set; }
    public float low { get; set; }
    public float close { get; set; }
    public int volume { get; set; }
    public int unadjustedVolume { get; set; }
    public float change { get; set; }
    public float changePercent { get; set; }
    public float vwap { get; set; }
    public string label { get; set; }
    public float changeOverTime { get; set; }
    public string symbol { get; set; }
  }

  public class ChartRoot
  {
    public Quote[] chart { get; set; }
  }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Enrolment> enrolments { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }

        public List<Enrolment> enrolments { get; set; }
    }

    public class Enrolment
    {
        public int Id { get; set; }

        public Course course { get; set; }
        public Student student { get; set; }

        public string grade { get; set; }
    }
}