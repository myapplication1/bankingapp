﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app.com.Extensions
{
  public static class DateTimeExtensions
  {
    public static int CalculateAge(this DateTime theDateTime)
    {
      // Bruteforce Age
      var age = DateTime.Today.Year - theDateTime.Year;
      if (theDateTime.AddYears(age) > DateTime.Today)
      {
        age--;
      }

      return age;
    }
  }
}