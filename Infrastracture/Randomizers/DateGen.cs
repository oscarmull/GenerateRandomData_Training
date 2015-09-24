using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class DateGen
    {
        public DateTime GenerateRandomBirthdate() {
            return Faker.DateTimeFaker.BirthDay();
        }
        public DateTime GenerateRandomBirthdateMinAge(int minAge)
        {
            int year = Randomizer.Number.RandomIntMinMax(1900,System.DateTime.Now.Year - minAge);
            int month = Randomizer.Number.RandomIntMinMax(1,System.DateTime.Now.Month);
            int day = Randomizer.Number.RandomIntMinMax(1,System.DateTime.Now.Day);
            return new DateTime(year, month, day);
        }
        public DateTime GenerateRandomBirthdateMinDate(int minAge,int maxAge)
        {
            int year = Randomizer.Number.RandomIntMinMax(System.DateTime.Now.Year - maxAge,System.DateTime.Now.Year - minAge);
            int month = Randomizer.Number.RandomIntMinMax(1, System.DateTime.Now.Month);
            int day = Randomizer.Number.RandomIntMinMax(1, System.DateTime.Now.Day);
            return new DateTime(year, month, day);
        }

        public DateTime GenerateRandomDate(){
            return Faker.DateTimeFaker.DateTime();
        }

        public DateTime GenerateRandomDate(DateTime from, DateTime to)
        {
            return Faker.DateTimeFaker.DateTime(from, to);
        }
        public DateTime GenerateRandomDateBewtweenTwoYears(int minYear, int maxYear) {
            DateTime minDate = this.GenerateRandomDateInGivenYear(minYear);
            DateTime maxDate = this.GenerateRandomDateInGivenYear(maxYear);
            return this.GenerateRandomDate(minDate, maxDate);
        }

        public DateTime GenerateRandomDateInGivenMonth(int month) {

            int year = Randomizer.Number.RandomIntMinMax(1900, System.DateTime.Now.Year);
            int day = Randomizer.Number.RandomIntMinMax(1, System.DateTime.DaysInMonth(year,month));
            return new DateTime(year, month, day);
        }
        public DateTime GenerateRandomDateInGivenYear(int year)
        {
            int month = Randomizer.Number.RandomIntMinMax(1, 12);
            int day = Randomizer.Number.RandomIntMinMax(1, System.DateTime.DaysInMonth(year, month));
            return new DateTime(year, month, day);
        }

        public DateTime GenerateLastDayOfFebruaryForAYear(int year) {
            return new DateTime(year, 2, System.DateTime.DaysInMonth(year, 2));
        }

        public DateTime GenerateRandomLeapYearDate(){
            int year = Randomizer.Number.RandomIntMinMax(1900, System.DateTime.Now.Year);
            while (System.DateTime.IsLeapYear(year)) {
                year = Randomizer.Number.RandomIntMinMax(1900, System.DateTime.Now.Year);
            }
            int month = Randomizer.Number.RandomIntMinMax(1, 12);
            int day = Randomizer.Number.RandomIntMinMax(1, System.DateTime.DaysInMonth(year, month));
            return new DateTime(year, month, day);
        }

    }
}
