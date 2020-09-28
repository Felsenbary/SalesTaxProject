using SalesTaxRate.TaxRateRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesTaxRate
{
    /// <summary>
    /// This function Get the tax rate in NC by the city
    /// </summary>
    public class NCTaxRateRepository : ITaxRateRepository
    {
        public async Task<decimal> GetTaxRateByCityAsync(string city)
        {
            var taxRate = Task<decimal>.Factory.StartNew(() => 0m);
            if (string.IsNullOrEmpty(city))
                return await taxRate;

            var ncTaxRate = new NCTaxRateRepository();
            if (ncTaxRate.TaxRate.TryGetValue(city, out decimal rate))
                taxRate = Task<decimal>.Factory.StartNew(() => rate);

            return await taxRate;
        }

        // This data was retrieved from https://www.salestaxhandbook.com/north-carolina/rates

        readonly Dictionary<string, decimal> TaxRate = new Dictionary<string, decimal>(StringComparer.InvariantCultureIgnoreCase)
        {
             {"Burlington", 0.0675m}
            ,{"Graham", 0.0675m}
            ,{"Mebane",  0.0675m}
            ,{"Elon",  0.0675m}
            ,{"Haw River",  0.0675m}
            ,{"Snow Camp",  0.0675m}
            ,{"Alamance",  0.0675m}
            ,{"Altamahaw",  0.0675m}
            ,{"Saxapahaw",  0.0675m}
            ,{"Swepsonville",  0.0675m}
            ,{"Taylorsville",  0.0700m}
            ,{"Hiddenite",  0.0700m}
            ,{"Stony Point",  0.0700m}
            ,{"Scotts",  0.0675m}
            ,{"Sparta",  0.0675m}
            ,{"Ennice",  0.0675m}
            ,{"Laurel Springs",  0.0675m}
            ,{"Glade Valley" ,  0.0675m}
            ,{"Piney Creek",  0.0675m}
            ,{"Roaring Gap",  0.0675m}
            ,{"Wadesboro",  0.0700m}
            ,{"Polkton",  0.0700m}
            ,{"Peachland",  0.0700m}
            ,{"Morven",  0.0700m}
            ,{"Lilesville",  0.0700m}
            ,{"Ansonville",  0.0700m}
            ,{"Mc Farlan",  0.0700m}
            ,{"West Jefferson	",  0.0700m}
            ,{"Jefferson",  0.0700m}
            ,{"Lansing",  0.0700m}
            ,{"Fleetwood",  0.0700m}
            ,{"Crumpler" ,  0.0700m}
            ,{"Creston",  0.0700m}
            ,{"Todd" ,  0.0700m}
            ,{"Warrensville" ,  0.0700m}
            ,{"Grassy Creek" ,  0.0700m}
            ,{"Scottville",  0.0700m}
            ,{"Glendale Springs",  0.0700m}
            ,{"Newland",  0.0675m}
            ,{"Banner Elk",  0.0675m}
            ,{"Elk Park" ,  0.0675m}
            ,{"Linville" ,  0.0675m}
            ,{"Collettsville",  0.0675m}
            ,{"Crossnore",  0.0675m}
            ,{"Pineola",  0.0675m}
            ,{"Plumtree" ,  0.0675m}
            ,{"Montezuma",  0.0675m}
            ,{"Jonas Ridge",  0.0675m}
            ,{"Minneapolis",  0.0675m}
            ,{"Linville Falls",  0.0675m}
            ,{"Washington",  0.0675m}
            ,{"Chocowinity",  0.0675m}
            ,{"Belhaven" ,  0.0675m}
            ,{"Bath" ,  0.0675m}
            ,{"Aurora",  0.0675m}
            ,{"Pantego",  0.0675m}
            ,{"Pinetown" ,  0.0675m}
            ,{"Blounts Creek",  0.0675m}
            ,{"Edward",  0.0675m}
            ,{"Windsor",  0.0675m}
            ,{"Aulander" ,  0.0675m}
            ,{"Colerain" ,  0.0675m}
            ,{"Lewiston Woodville",  0.0675m}
            ,{"Merry Hill",  0.0675m}
            ,{"Kelford",  0.0675m}
            ,{"Powellsville" ,  0.0675m}
            ,{"Roxobel",  0.0675m}
            ,{"Elizabethtown",  0.0675m}
            ,{"Bladenboro",  0.0675m}
            ,{"Clarkton" ,  0.0675m}
            ,{"Tar Heel" ,  0.0675m}
            ,{"White Oak",  0.0675m}
            ,{"Council",  0.0675m}
            ,{"Kelly",  0.0675m}
            ,{"Dublin",  0.0675m}
            ,{"Leland",  0.0675m}
            ,{"Southport",  0.0675m}
            ,{"Supply",  0.0675m}
            ,{"Calabash" ,  0.0675m}
            ,{"Shallotte",  0.0675m}
            ,{"Oak Island",  0.0675m}
            ,{"Ocean Isle Beach" ,  0.0675m}
            ,{"Bolivia",  0.0675m}
            ,{"Winnabow" ,  0.0675m}
            ,{"Sunset Beach" ,  0.0675m}
            ,{"Ash",  0.0675m}
            ,{"Longwood" ,  0.0675m}
            ,{"Asheville",  0.0700m}
            ,{"Candler",  0.0700m}
            ,{"Weaverville",  0.0700m}
            ,{"Arden",  0.0700m}
            ,{"Fletcher" ,  0.0675m}
            ,{"Black Mountain	",  0.0700m}
            ,{"Leicester",  0.0700m}
            ,{"Fairview" ,  0.0700m}
            ,{"Swannanoa",  0.0700m}
            ,{"Alexander",  0.0700m}
            ,{"Barnardsville",  0.0700m}
            ,{"Enka" ,  0.0700m}
            ,{"Skyland",  0.0700m}
            ,{"Montreat" ,  0.0700m}
            ,{"Ridgecrest",  0.0700m}
            ,{"Morganton",  0.0675m}
            ,{"Connellys Springs",  0.0675m}
            ,{"Valdese",  0.0675m}
            ,{"Hildebran",  0.0675m}
            ,{"Drexel",  0.0675m}
            ,{"Glen Alpine",  0.0675m}
            ,{"Icard",  0.0675m}
            ,{"Rutherford College",  0.0675m}
            ,{"Concord",  0.0700m}
            ,{"Kannapolis",  0.0700m}
            ,{"Harrisburg",  0.0700m}
            ,{"Mount Pleasant",  0.0700m}
            ,{"Midland",  0.0700m}
            ,{"Lenoir",  0.0675m}
            ,{"Granite Falls",  0.0675m}
            ,{"Hudson",  0.0675m}
            ,{"Patterson",  0.0675m}
            ,{"Camden",  0.0675m}
            ,{"South Mills",  0.0675m}
            ,{"Shiloh",  0.0675m}
            ,{"Newport",  0.0675m}
            ,{"Morehead City",  0.0675m}
            ,{"Beaufort" ,  0.0675m}
            ,{"Emerald Isle" ,  0.0675m}
            ,{"Atlantic Beach",  0.0675m}
            ,{"Stella",  0.0700m}
            ,{"Harkers Island",  0.0675m}
            ,{"Gloucester",  0.0675m}
            ,{"Atlantic" ,  0.0675m}
            ,{"Smyrna",  0.0675m}
            ,{"Davis",  0.0675m}
            ,{"Stacy",  0.0675m}
            ,{"Sealevel" ,  0.0675m}
            ,{"Salter Path",  0.0675m}
            ,{"Cedar Island" ,  0.0675m}
            ,{"Marshallberg" ,  0.0675m}
            ,{"Yanceyville",  0.0675m}
            ,{"Pelham",  0.0675m}
            ,{"Providence",  0.0675m}
            ,{"Leasburg" ,  0.0675m}
            ,{"Milton",  0.0675m}
            ,{"Blanch",  0.0675m}
            ,{"Prospect Hill",  0.0675m}
            ,{"Hickory",  0.0700m}
            ,{"Newton",  0.0700m}
            ,{"Conover",  0.0700m}
            ,{"Maiden",  0.0700m}
            ,{"Claremont",  0.0700m}
            ,{"Sherrills Ford",  0.0700m}
            ,{"Catawba",  0.0700m}
            ,{"Terrell",  0.0700m}
            ,{"Pittsboro",  0.0675m}
            ,{"Siler City",  0.0675m}
            ,{"Bear Creek",  0.0675m}
            ,{"Moncure",  0.0675m}
            ,{"Goldston" ,  0.0675m}
            ,{"Bennett",  0.0675m}
            ,{"Gulf" ,  0.0675m}
            ,{"Bonlee",  0.0675m}
            ,{"Highfalls",  0.0700m}
            ,{"Murphy",  0.0700m}
            ,{"Andrews",  0.0700m}
            ,{"Marble",  0.0700m}
            ,{"Brasstown",  0.0700m}
            ,{"Culberson",  0.0700m}
            ,{"Edenton",  0.0675m}
            ,{"Tyner",  0.0675m}
            ,{"Hayesville",  0.0700m}
            ,{"Warne",  0.0700m}
            ,{"Shelby",  0.0675m}
            ,{"Kings Mountain",  0.0675m}
            ,{"Lawndale" ,  0.0675m}
            ,{"Grover",  0.0675m}
            ,{"Casar",  0.0675m}
            ,{"Boiling Springs",  0.0675m}
            ,{"Fallston" ,  0.0675m}
            ,{"Polkville",  0.0675m}
            ,{"Earl" ,  0.0675m}
            ,{"Waco" ,  0.0675m}
            ,{"Lattimore",  0.0675m}
            ,{"Whiteville",  0.0675m}
            ,{"Tabor City",  0.0675m}
            ,{"Chadbourn",  0.0675m}
            ,{"Riegelwood",  0.0675m}
            ,{"Delco",  0.0675m}
            ,{"Lake Waccamaw",  0.0675m}
            ,{"Bolton",  0.0675m}
            ,{"Clarendon",  0.0675m}
            ,{"Cerro Gordo",  0.0675m}
            ,{"Nakina",  0.0675m}
            ,{"Evergreen",  0.0675m}
            ,{"Hallsboro",  0.0675m}
            ,{"Fair Bluff",  0.0675m}
            ,{"Brunswick",  0.0675m}
            ,{"New Bern" ,  0.0675m}
            ,{"Havelock" ,  0.0675m}
            ,{"Vanceboro",  0.0675m}
            ,{"Cove City",  0.0675m}
            ,{"Cherry Point" ,  0.0675m}
            ,{"Dover",  0.0675m}
            ,{"Ernul",  0.0675m}
            ,{"Bridgeton",  0.0675m}
            ,{"Fayetteville" ,  0.0700m}
            ,{"Hope Mills",  0.0700m}
            ,{"Fort Bragg",  0.0700m}
            ,{"Stedman",  0.0700m}
            ,{"Linden",  0.0700m}
            ,{"Wade" ,  0.0700m}
            ,{"Pope Army Airfield",  0.0700m}
            ,{"Falcon",  0.0700m}
            ,{"Cumberland",  0.0700m}
            ,{"Moyock",  0.0675m}
            ,{"Grandy",  0.0675m}
            ,{"Knotts Island",  0.0675m}
            ,{"Shawboro" ,  0.0675m}
            ,{"Currituck",  0.0675m}
            ,{"Powells Point",  0.0675m}
            ,{"Jarvisburg",  0.0675m}
            ,{"Corolla",  0.0675m}
            ,{"Aydlett",  0.0675m}
            ,{"Harbinger",  0.0675m}
            ,{"Barco",  0.0675m}
            ,{"Coinjock" ,  0.0675m}
            ,{"Point Harbor" ,  0.0675m}
            ,{"Poplar Branch",  0.0675m}
            ,{"Maple",  0.0675m}
            ,{"Kill Devil Hills" ,  0.0675m}
            ,{"Kitty Hawk",  0.0675m}
            ,{"Manteo",  0.0675m}
            ,{"Nags Head",  0.0675m}
            ,{"Wanchese" ,  0.0675m}
            ,{"Buxton",  0.0675m}
            ,{"Manns Harbor" ,  0.0675m}
            ,{"Avon" ,  0.0675m}
            ,{"Hatteras" ,  0.0675m}
            ,{"Frisco",  0.0675m}
            ,{"Rodanthe" ,  0.0675m}
            ,{"Stumpy Point" ,  0.0675m}
            ,{"Lexington",  0.0700m}
            ,{"Thomasville",  0.0700m}
            ,{"Denton",  0.0700m}
            ,{"Linwood",  0.0700m}
            ,{"Welcome",  0.0700m}
            ,{"Southmont",  0.0700m}
            ,{"Wallburg" ,  0.0700m}
            ,{"Mocksville",  0.0675m}
            ,{"Advance",  0.0675m}
            ,{"Cooleemee",  0.0675m}
            ,{"Mount Olive",  0.0675m}
            ,{"Wallace",  0.0700m}
            ,{"Beulaville",  0.0700m}
            ,{"Warsaw",  0.0700m}
            ,{"Rose Hill",  0.0700m}
            ,{"Faison",  0.0700m}
            ,{"Kenansville",  0.0700m}
            ,{"Magnolia" ,  0.0700m}
            ,{"Teachey",  0.0700m}
            ,{"Chinquapin",  0.0700m}
            ,{"Albertson",  0.0700m}
            ,{"Calypso",  0.0700m}
            ,{"Durham",  0.0750m}
            ,{"Bahama",  0.0750m}
            ,{"Rocky Mount",  0.0700m}
            ,{"Tarboro",  0.0700m}
            ,{"Pinetops" ,  0.0700m}
            ,{"Macclesfield" ,  0.0700m}
            ,{"Hobgood",  0.0700m}
            ,{"Conetoe",  0.0700m}
            ,{"Speed",  0.0700m}
            ,{"Winston Salem",  0.0675m}
            ,{"Kernersville" ,  0.0675m}
            ,{"Clemmons" ,  0.0675m}
            ,{"Lewisville",  0.0675m}
            ,{"Pfafftown",  0.0675m}
            ,{"Rural Hall",  0.0675m}
            ,{"Walkertown",  0.0675m}
            ,{"Tobaccoville" ,  0.0675m}
            ,{"Belews Creek" ,  0.0675m}
            ,{"Bethania" ,  0.0675m}
            ,{"Louisburg",  0.0675m}
            ,{"Youngsville",  0.0675m}
            ,{"Franklinton",  0.0675m}
            ,{"Castalia" ,  0.0675m}
            ,{"Bunn" ,  0.0675m}
            ,{"Gastonia" ,  0.0700m}
            ,{"Belmont",  0.0700m}
            ,{"Mount Holly",  0.0700m}
            ,{"Dallas",  0.0700m}
            ,{"Stanley",  0.0700m}
            ,{"Cherryville",  0.0700m}
            ,{"Bessemer City",  0.0700m}
            ,{"Lowell",  0.0700m}
            ,{"Cramerton",  0.0700m}
            ,{"Alexis",  0.0700m}
            ,{"Mc Adenville" ,  0.0700m}
            ,{"High Shoals",  0.0700m}
            ,{"Gates",  0.0675m}
            ,{"Corapeake",  0.0675m}
            ,{"Sunbury",  0.0675m}
            ,{"Eure" ,  0.0675m}
            ,{"Gatesville",  0.0675m}
            ,{"Hobbsville",  0.0675m}
            ,{"Roduco",  0.0675m}
            ,{"Robbinsville" ,  0.0700m}
            ,{"Almond",  0.0700m}
            ,{"Fontana Dam",  0.0700m}
            ,{"Oxford",  0.0675m}
            ,{"Creedmoor",  0.0675m}
            ,{"Butner",  0.0675m}
            ,{"Stem" ,  0.0675m}
            ,{"Bullock",  0.0675m}
            ,{"Stovall",  0.0675m}
            ,{"Snow Hill",  0.0700m}
            ,{"Walstonburg",  0.0700m}
            ,{"Hookerton",  0.0700m}
            ,{"Maury",  0.0700m}
            ,{"Greensboro",  0.0675m}
            ,{"High Point",  0.0675m}
            ,{"Jamestown",  0.0675m}
            ,{"Summerfield",  0.0675m}
            ,{"Gibsonville",  0.0675m}
            ,{"Browns Summit",  0.0675m}
            ,{"Mc Leansville",  0.0675m}
            ,{"Oak Ridge",  0.0675m}
            ,{"Pleasant Garden",  0.0675m}
            ,{"Whitsett" ,  0.0675m}
            ,{"Colfax",  0.0675m}
            ,{"Julian",  0.0675m}
            ,{"Sedalia",  0.0675m}
            ,{"Roanoke Rapids",  0.0700m}
            ,{"Enfield",  0.0700m}
            ,{"Scotland Neck",  0.0700m}
            ,{"Halifax",  0.0700m}
            ,{"Hollister",  0.0700m}
            ,{"Weldon",  0.0700m}
            ,{"Tillery",  0.0700m}
            ,{"Dunn" ,  0.0700m}
            ,{"Spring Lake",  0.0700m}
            ,{"Angier",  0.0700m}
            ,{"Cameron",  0.0700m}
            ,{"Lillington",  0.0700m}
            ,{"Erwin",  0.0700m}
            ,{"Broadway" ,  0.0700m}
            ,{"Coats",  0.0700m}
            ,{"Bunnlevel",  0.0700m}
            ,{"Buies Creek",  0.0700m}
            ,{"Olivia",  0.0700m}
            ,{"Mamers",  0.0700m}
            ,{"Kipling",  0.0700m}
            ,{"Waynesville",  0.0700m}
            ,{"Canton",  0.0700m}
            ,{"Clyde",  0.0700m}
            ,{"Maggie Valley",  0.0700m}
            ,{"Lake Junaluska",  0.0700m}
            ,{"Hazelwood",  0.0700m}
            ,{"Hendersonville",  0.0675m}
            ,{"Flat Rock",  0.0675m}
            ,{"Mills River",  0.0675m}
            ,{"Etowah",  0.0675m}
            ,{"Horse Shoe",  0.0675m}
            ,{"East Flat Rock",  0.0675m}
            ,{"Zirconia" ,  0.0675m}
            ,{"Dana" ,  0.0675m}
            ,{"Mountain Home",  0.0675m}
            ,{"Edneyville",  0.0675m}
            ,{"Gerton",  0.0675m}
            ,{"Naples",  0.0675m}
            ,{"Tuxedo",  0.0675m}
            ,{"Bat Cave" ,  0.0675m}
            ,{"Ahoskie",  0.0700m}
            ,{"Murfreesboro" ,  0.0700m}
            ,{"Como" ,  0.0700m}
            ,{"Winton",  0.0700m}
            ,{"Cofield",  0.0700m}
            ,{"Harrellsville",  0.0700m}
            ,{"Raeford",  0.0675m}
            ,{"Engelhard",  0.0675m}
            ,{"Ocracoke" ,  0.0675m}
            ,{"Swanquarter",  0.0675m}
            ,{"Fairfield",  0.0675m}
            ,{"Scranton" ,  0.0675m}
            ,{"Mooresville",  0.0675m}
            ,{"Statesville",  0.0675m}
            ,{"Troutman" ,  0.0675m}
            ,{"Harmony",  0.0675m}
            ,{"Olin" ,  0.0675m}
            ,{"Union Grove",  0.0675m}
            ,{"Turnersburg",  0.0675m}
            ,{"Mount Mourne" ,  0.0675m}
            ,{"Barium Springs",  0.0675m}
            ,{"Sylva",  0.0700m}
            ,{"Cullowhee",  0.0700m}
            ,{"Whittier" ,  0.0700m}
            ,{"Cashiers" ,  0.0700m}
            ,{"Tuckasegee",  0.0700m}
            ,{"Dillsboro",  0.0700m}
            ,{"Sapphire" ,  0.0700m}
            ,{"Webster",  0.0700m}
            ,{"Glenville",  0.0700m}
            ,{"Balsam",  0.0700m}
            ,{"Clayton",  0.0675m}
            ,{"Smithfield	",  0.0675m}
            ,{"Selma",  0.0675m}
            ,{"Benson",  0.0675m}
            ,{"Four Oaks",  0.0675m}
            ,{"Kenly",  0.0675m}
            ,{"Princeton",  0.0675m}
            ,{"Pine Level",  0.0675m}
            ,{"Micro",  0.0675m}
            ,{"Wilsons Mills",  0.0675m}
            ,{"Trenton",  0.0700m}
            ,{"Pollocksville",  0.0700m}
            ,{"Comfort",  0.0700m}
            ,{"Sanford",  0.0700m}
            ,{"Lemon Springs",  0.0700m}
            ,{"Kinston",  0.0675m}
            ,{"La Grange",  0.0675m}
            ,{"Pink Hill",  0.0700m}
            ,{"Deep Run" ,  0.0675m}
            ,{"Lincolnton",  0.0700m}
            ,{"Denver",  0.0700m}
            ,{"Vale" ,  0.0700m}
            ,{"Iron Station" ,  0.0700m}
            ,{"Crouse",  0.0700m}
            ,{"Franklin" ,  0.0675m}
            ,{"Highlands",  0.0675m}
            ,{"Otto" ,  0.0675m}
            ,{"Topton",  0.0675m}
            ,{"Scaly Mountain",  0.0675m}
            ,{"Marshall" ,  0.0675m}
            ,{"Mars Hill",  0.0675m}
            ,{"Hot Springs",  0.0675m}
            ,{"Williamston",  0.0700m}
            ,{"Robersonville",  0.0700m}
            ,{"Jamesville",  0.0700m}
            ,{"Oak City" ,  0.0700m}
            ,{"Hamilton" ,  0.0700m}
            ,{"Hassell",  0.0700m}
            ,{"Parmele",  0.0700m}
            ,{"Everetts" ,  0.0700m}
            ,{"Marion",  0.0675m}
            ,{"Nebo" ,  0.0675m}
            ,{"Old Fort" ,  0.0675m}
            ,{"Charlotte",  0.0725m}
            ,{"Huntersville" ,  0.0725m}
            ,{"Cornelius",  0.0725m}
            ,{"Davidson" ,  0.0725m}
            ,{"Pineville",  0.0725m}
            ,{"Newell",  0.0725m}
            ,{"Paw Creek",  0.0725m}
            ,{"Spruce Pine",  0.0675m}
            ,{"Bakersville",  0.0675m}
            ,{"Penland",  0.0675m}
            ,{"Little Switzerland",  0.0675m}
            ,{"Troy" ,  0.0700m}
            ,{"Mount Gilead" ,  0.0700m}
            ,{"Biscoe",  0.0700m}
            ,{"Candor",  0.0700m}
            ,{"Star" ,  0.0700m}
            ,{"Ether",  0.0700m}
            ,{"Pinehurst",  0.0700m}
            ,{"Carthage" ,  0.0700m}
            ,{"Southern Pines",  0.0700m}
            ,{"Aberdeen" ,  0.0700m}
            ,{"West End" ,  0.0700m}
            ,{"Robbins",  0.0700m}
            ,{"Vass" ,  0.0700m}
            ,{"Pinebluff",  0.0700m}
            ,{"Jackson Springs",  0.0700m}
            ,{"Eagle Springs",  0.0700m}
            ,{"Lakeview" ,  0.0700m}
            ,{"Nashville",  0.0675m}
            ,{"Spring Hope",  0.0675m}
            ,{"Middlesex",  0.0675m}
            ,{"Bailey",  0.0675m}
            ,{"Whitakers",  0.0675m}
            ,{"Battleboro",  0.0675m}
            ,{"Sharpsburg",  0.0675m}
            ,{"Red Oak",  0.0675m}
            ,{"Wilmington",  0.0700m}
            ,{"Castle Hayne" ,  0.0700m}
            ,{"Carolina Beach",  0.0700m}
            ,{"Wrightsville Beach",  0.0700m}
            ,{"Kure Beach",  0.0700m}
            ,{"Gaston",  0.0675m}
            ,{"Garysburg",  0.0675m}
            ,{"Conway",  0.0675m}
            ,{"Rich Square",  0.0675m}
            ,{"Jackson",  0.0675m}
            ,{"Henrico",  0.0675m}
            ,{"Woodland" ,  0.0675m}
            ,{"Seaboard" ,  0.0675m}
            ,{"Pleasant Hill",  0.0675m}
            ,{"Pendleton",  0.0675m}
            ,{"Severn",  0.0675m}
            ,{"Potecasi" ,  0.0675m}
            ,{"Margarettsville",  0.0675m}
            ,{"Jacksonville" ,  0.0700m}
            ,{"Hubert",  0.0700m}
            ,{"Richlands",  0.0700m}
            ,{"Swansboro",  0.0700m}
            ,{"Sneads Ferry" ,  0.0700m}
            ,{"Camp Lejeune" ,  0.0700m}
            ,{"Holly Ridge",  0.0675m}
            ,{"Midway Park",  0.0700m}
            ,{"Maysville",  0.0700m}
            ,{"Tarawa Terrace",  0.0700m}
            ,{"Mccutcheon Field" ,  0.0700m}
            ,{"Chapel Hill",  0.0750m}
            ,{"Hillsborough" ,  0.0750m}
            ,{"Carrboro" ,  0.0750m}
            ,{"Efland",  0.0750m}
            ,{"Cedar Grove",  0.0750m}
            ,{"Oriental" ,  0.0675m}
            ,{"Bayboro",  0.0675m}
            ,{"Grantsboro",  0.0675m}
            ,{"Arapahoe" ,  0.0675m}
            ,{"Merritt",  0.0675m}
            ,{"Lowland",  0.0675m}
            ,{"Alliance" ,  0.0675m}
            ,{"Hobucken" ,  0.0675m}
            ,{"Stonewall",  0.0675m}
            ,{"Vandemere",  0.0675m}
            ,{"Elizabeth City",  0.0700m}
            ,{"Hampstead",  0.0675m}
            ,{"Rocky Point",  0.0675m}
            ,{"Burgaw",  0.0675m}
            ,{"Willard",  0.0675m}
            ,{"Maple Hill",  0.0675m}
            ,{"Currie",  0.0675m}
            ,{"Atkinson" ,  0.0675m}
            ,{"Hertford" ,  0.0675m}
            ,{"Belvidere",  0.0675m}
            ,{"Winfall",  0.0675m}
            ,{"Roxboro",  0.0675m}
            ,{"Timberlake",  0.0675m}
            ,{"Rougemont",  0.0750m}
            ,{"Hurdle Mills" ,  0.0675m}
            ,{"Semora",  0.0675m}
            ,{"Greenville",  0.0700m}
            ,{"Winterville",  0.0700m}
            ,{"Ayden",  0.0700m}
            ,{"Farmville",  0.0700m}
            ,{"Grifton",  0.0700m}
            ,{"Grimesland",  0.0700m}
            ,{"Bethel",  0.0700m}
            ,{"Fountain" ,  0.0700m}
            ,{"Stokes",  0.0700m}
            ,{"Saratoga" ,  0.0675m}
            ,{"Simpson",  0.0700m}
            ,{"Falkland" ,  0.0700m}
            ,{"Bellarthur",  0.0700m}
            ,{"Columbus" ,  0.0675m}
            ,{"Tryon",  0.0675m}
            ,{"Mill Spring",  0.0675m}
            ,{"Saluda",  0.0675m}
            ,{"Lynn" ,  0.0675m}
            ,{"Asheboro" ,  0.0700m}
            ,{"Randleman",  0.0700m}
            ,{"Trinity",  0.0700m}
            ,{"Liberty",  0.0700m}
            ,{"Ramseur",  0.0700m}
            ,{"Sophia",  0.0700m}
            ,{"Seagrove" ,  0.0700m}
            ,{"Franklinville",  0.0700m}
            ,{"Climax",  0.0700m}
            ,{"Staley",  0.0700m}
            ,{"Cedar Falls",  0.0700m}
            ,{"Hamlet",  0.0675m}
            ,{"Ellerbe",  0.0675m}
            ,{"Rockingham",  0.0675m}
            ,{"Marston",  0.0675m}
            ,{"Cordova",  0.0675m}
            ,{"Hoffman",  0.0675m}
            ,{"Norman",  0.0675m}
            ,{"Pembroke" ,  0.0700m}
            ,{"Maxton",  0.0700m}
            ,{"Saint Pauls",  0.0700m}
            ,{"Lumberton",  0.0700m}
            ,{"Red Springs",  0.0700m}
            ,{"Fairmont" ,  0.0700m}
            ,{"Rowland",  0.0700m}
            ,{"Parkton",  0.0700m}
            ,{"Shannon",  0.0700m}
            ,{"Lumber Bridge",  0.0700m}
            ,{"Orrum",  0.0700m}
            ,{"Rex",  0.0700m}
            ,{"Marietta" ,  0.0700m}
            ,{"Proctorville" ,  0.0700m}
            ,{"Reidsville",  0.0700m}
            ,{"Eden" ,  0.0700m}
            ,{"Madison",  0.0700m}
            ,{"Stoneville",  0.0700m}
            ,{"Stokesdale",  0.0700m}
            ,{"Mayodan",  0.0700m}
            ,{"Ruffin",  0.0700m}
            ,{"Wentworth",  0.0700m}
            ,{"Salisbury",  0.0700m}
            ,{"China Grove",  0.0700m}
            ,{"Rockwell" ,  0.0700m}
            ,{"Cleveland",  0.0700m}
            ,{"Landis",  0.0700m}
            ,{"Spencer",  0.0700m}
            ,{"Gold Hill",  0.0700m}
            ,{"Woodleaf" ,  0.0700m}
            ,{"Mount Ulla",  0.0700m}
            ,{"Granite Quarry",  0.0700m}
            ,{"Faith",  0.0700m}
            ,{"East Spencer" ,  0.0700m}
            ,{"Rutherfordton",  0.0700m}
            ,{"Forest City",  0.0700m}
            ,{"Ellenboro",  0.0700m}
            ,{"Mooresboro",  0.0675m}
            ,{"Bostic",  0.0700m}
            ,{"Spindale" ,  0.0700m}
            ,{"Lake Lure",  0.0700m}
            ,{"Union Mills",  0.0700m}
            ,{"Henrietta",  0.0700m}
            ,{"Cliffside",  0.0700m}
            ,{"Caroleen" ,  0.0700m}
            ,{"Harris",  0.0700m}
            ,{"Chimney Rock" ,  0.0700m}
            ,{"Roseboro" ,  0.0700m}
            ,{"Newton Grove" ,  0.0700m}
            ,{"Autryville",  0.0700m}
            ,{"Clinton",  0.0700m}
            ,{"Garland",  0.0700m}
            ,{"Salemburg",  0.0700m}
            ,{"Godwin",  0.0700m}
            ,{"Harrells" ,  0.0700m}
            ,{"Turkey",  0.0700m}
            ,{"Ivanhoe",  0.0700m}
            ,{"Laurinburg",  0.0675m}
            ,{"Laurel Hill",  0.0675m}
            ,{"Wagram",  0.0675m}
            ,{"Gibson",  0.0675m}
            ,{"Albemarle",  0.0700m}
            ,{"Norwood",  0.0700m}
            ,{"New London",  0.0700m}
            ,{"Oakboro",  0.0700m}
            ,{"Locust",  0.0700m}
            ,{"Stanfield",  0.0700m}
            ,{"Richfield",  0.0700m}
            ,{"Badin",  0.0700m}
            ,{"Misenheimer",  0.0700m}
            ,{"King" ,  0.0675m}
            ,{"Walnut Cove",  0.0675m}
            ,{"Germanton",  0.0675m}
            ,{"Westfield",  0.0675m}
            ,{"Sandy Ridge",  0.0675m}
            ,{"Danbury",  0.0675m}
            ,{"Lawsonville",  0.0675m}
            ,{"Pine Hall",  0.0675m}
            ,{"Mount Airy",  0.0700m}
            ,{"Elkin",  0.0700m}
            ,{"Dobson",  0.0700m}
            ,{"Pilot Mountain",  0.0700m}
            ,{"Pinnacle" ,  0.0675m}
            ,{"State Road",  0.0700m}
            ,{"Lowgap",  0.0700m}
            ,{"Ararat",  0.0700m}
            ,{"Thurmond" ,  0.0700m}
            ,{"Siloam",  0.0700m}
            ,{"Toast",  0.0700m}
            ,{"White Plains" ,  0.0700m}
            ,{"Bryson City",  0.0700m}
            ,{"Cherokee" ,  0.0700m}
            ,{"Brevard",  0.0675m}
            ,{"Pisgah Forest",  0.0675m}
            ,{"Rosman",  0.0675m}
            ,{"Lake Toxaway" ,  0.0675m}
            ,{"Penrose",  0.0675m}
            ,{"Cedar Mountain",  0.0675m}
            ,{"Balsam Grove" ,  0.0675m}
            ,{"Columbia" ,  0.0675m}
            ,{"Monroe",  0.0675m}
            ,{"Waxhaw",  0.0675m}
            ,{"Indian Trail" ,  0.0675m}
            ,{"Matthews" ,  0.0675m}
            ,{"Marshville",  0.0675m}
            ,{"Wingate",  0.0675m}
            ,{"Mineral Springs",  0.0675m}
            ,{"Henderson",  0.0675m}
            ,{"Kittrell" ,  0.0675m}
            ,{"Townsville",  0.0675m}
            ,{"Middleburg",  0.0675m}
            ,{"Raleigh",  0.0725m}
            ,{"Cary" ,  0.0725m}
            ,{"Wake Forest",  0.0725m}
            ,{"Littleton",  0.0700m}
            ,{"Warrenton",  0.0675m}
            ,{"Norlina",  0.0675m}
            ,{"Manson",  0.0675m}
            ,{"Macon",  0.0675m}
            ,{"Wise" ,  0.0675m}
            ,{"Vaughan",  0.0675m}
            ,{"Ridgeway" ,  0.0675m}
            ,{"Plymouth" ,  0.0675m}
            ,{"Roper",  0.0675m}
            ,{"Creswell" ,  0.0675m}
            ,{"Blowing Rock" ,  0.0675m}
            ,{"Vilas",  0.0675m}
            ,{"Deep Gap" ,  0.0675m}
            ,{"Zionville",  0.0675m}
            ,{"Sugar Grove",  0.0675m}
            ,{"Boone",  0.0675m}
            ,{"Valle Crucis" ,  0.0675m}
            ,{"Goldsboro",  0.0675m}
            ,{"Pikeville",  0.0675m}
            ,{"Dudley",  0.0675m}
            ,{"Seven Springs",  0.0675m}
            ,{"Fremont",  0.0675m}
            ,{"Wilkesboro",  0.0700m}
            ,{"Millers Creek",  0.0700m}
            ,{"Hays" ,  0.0700m}
            ,{"Moravian Falls",  0.0700m}
            ,{"Roaring River",  0.0700m}
            ,{"Ronda",  0.0700m}
            ,{"Purlear",  0.0700m}
            ,{"Boomer",  0.0700m}
            ,{"Traphill" ,  0.0700m}
            ,{"Ferguson" ,  0.0700m}
            ,{"Mc Grady" ,  0.0700m}
            ,{"North Wilkesboro" ,  0.0700m}
            ,{"Wilson",  0.0675m}
            ,{"Elm City" ,  0.0675m}
            ,{"Lucama",  0.0675m}
            ,{"Stantonsburg" ,  0.0700m}
            ,{"Sims" ,  0.0675m}
            ,{"Black Creek",  0.0675m}
            ,{"Yadkinville",  0.0675m}
            ,{"East Bend",  0.0675m}
            ,{"Hamptonville" ,  0.0675m}
            ,{"Jonesville",  0.0675m}
            ,{"Boonville",  0.0675m}
            ,{"Burnsville",  0.0675m}
            ,{"Green Mountain",  0.0675m}
            ,{"Micaville",  0.0675m}
        };
    }
}