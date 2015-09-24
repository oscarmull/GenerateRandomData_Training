using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Address
    {
        public string GenerateRandomFullUSAddress() {
            var addressLine = this.GenerateRandomAddress();
            if (Faker.BooleanFaker.Boolean())
            {
                addressLine = this.GenerateRandomStreetAddressWithSecondary();
            }
            var streetSuffix = this.GenerateRandomStreetSuffix();
            if (Faker.BooleanFaker.Boolean()) {
                addressLine = String.Concat(addressLine, " ", streetSuffix);
            }
            var state = this.GenerateRandomUSStateAbbr();
            var city = this.GenerateRandomCity();
            var zip = this.GenerateRandomUSZipCode();
            return String.Format("{0} {1}, {2} {3}", addressLine, city, state, zip);
        }

        public string GenerateRandomCountryCode() {
            var list = new List<string> {"ALA","ALB","DZA","ASM","AND","AGO","AIA","ATA","ATG","ARG","ARM","ABW","AUS","AUT","AZE","BHS","BHR","BGD","BRB","BLR","BEL","BLZ","BEN","BMU","BTN","BOL","BIH",
                                         "BWA","BVT","BRA","VGB","IOT","BRN","BGR","BFA","BDI","KHM","CMR","CAN","CPV","CYM","CAF","TCD","CHL","CHN","HKG","MAC","CXR","CCK","COL","COM","COG","COD","COK",
                                         "CRI","CIV","HRV","CUB","CYP","CZE","DNK","DJI","DMA","DOM","ECU","EGY","SLV","GNQ","ERI","EST","ETH","FLK","FRO","FJI","FIN","FRA","GUF","PYF","ATF","GAB","GMB",
                                         "GEO","DEU","GHA","GIB","GRC","GRL","GRD","GLP","GUM","GTM","GGY","GIN","GNB","GUY","HTI","HMD","VAT","HND","HUN","ISL","IND","IDN","IRN","IRQ","IRL","IMN","ISR",
                                         "ITA","JAM","JPN","JEY","JOR","KAZ","KEN","KIR","PRK","KOR","KWT","KGZ","LAO","LVA","LBN","LSO","LBR","LBY","LIE","LTU","LUX","MKD","MDG","MWI","MYS","MDV","MLI",
                                         "MLT","MHL","MTQ","MRT","MUS","MYT","MEX","FSM","MDA","MCO","MNG","MNE","MSR","MAR","MOZ","MMR","NAM","NRU","NPL","NLD","ANT","NCL","NZL","NIC","NER","NGA","NIU",
                                         "NFK","MNP","NOR","OMN","PAK","PLW","PSE","PAN","PNG","PRY","PER","PHL","PCN","POL","PRT","PRI","QAT","REU","ROU","RUS","RWA","BLM","SHN","KNA","LCA","MAF","SPM",
                                         "VCT","WSM","SMR","STP","SAU","SEN","SRB","SYC","SLE","SGP","SVK","SVN","SLB","SOM","ZAF","SGS","SSD","ESP","LKA","SDN","SUR","SJM","SWZ","SWE","CHE","SYR","TWN",
                                         "TJK","TZA","THA","TLS","TGO","TKL","TON","TTO","TUN","TUR","TKM","TCA","TUV","UGA","UKR","ARE","GBR","USA","UMI","URY","UZB","VUT","VEN","VNM","VIR","WLF","ESH",
                                         "YEM","ZMB","ZWE" };
            return list[Randomizer.Number.RandomIntMinMax(0, list.Count)];
        }
        public string GenerateRandomFullUKAddress()
        {
            var addressLine = this.GenerateRandomAddress();
            if (Faker.BooleanFaker.Boolean())
            {
                addressLine = this.GenerateRandomStreetAddressWithSecondary();
            }
            var streetSuffix = this.GenerateRandomStreetSuffix();
            if (Faker.BooleanFaker.Boolean())
            {
                addressLine = String.Concat(addressLine, " ", streetSuffix);
            }
            var county = this.GenerateRandomUKCounty();
            var postal = this.GenerateRandomUKPostalCode();
            return String.Format("{0} {1}, {2}", addressLine, county, postal.ToUpper());
        }

        public string GenerateRandomAddress() {
            return Faker.Address.StreetAddress(); 
        }
        public string GenerateRandomCountry()
        {
            return Faker.Address.Country();
        }
        public string GenerateRandomStreetName()
        {
            return Faker.Address.StreetName();
        }
        public string GenerateRandomSecondaryAddress()
        {
            return Faker.Address.SecondaryAddress();
        }
        public string GenerateRandomCity()
        {
            return Faker.Address.City();
        }
        public string GenerateRandomStreetAddressWithSecondary()
        {
            return Faker.Address.StreetAddress(true);
        }
        public string GenerateRandomStreetSuffix()
        {
            return Faker.Address.StreetSuffix();
        }
        public string GenerateRandomUSState()
        {
            return Faker.Address.UsState();
        }
        public string GenerateRandomUSStateAbbr()
        {
            return Faker.Address.UsStateAbbr();
        }
        public string GenerateRandomUSZipCode()
        {
            return Faker.Address.ZipCode();
        }
        public string GenerateRandomUKPostalCode()
        {
            return Faker.Address.UkPostCode();
        }
        public string GenerateRandomUKCounty()
        {
            return Faker.Address.UkCounty();
        }
    }
}
