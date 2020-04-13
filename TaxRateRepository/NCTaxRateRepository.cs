using SalesTaxRate.TaxRateRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesTaxRate
{
    public class NCTaxRateRepository : ITaxRateRepository
    {
        public async Task<double> GetTaxRateByCityAsync(string city)
        {
            Task<double> taxRate = Task<double>.Factory.StartNew(() => 0.000);
            if (string.IsNullOrEmpty(city))
                return await taxRate;

            var ncTaxRate = new NCTaxRateRepository();
            if (ncTaxRate.TaxRate.TryGetValue(city,  out double rate))
                taxRate = Task<double>.Factory.StartNew(() => rate);

            return await taxRate;
        }

        readonly Dictionary<string, double> TaxRate = new Dictionary<string, double>(StringComparer.InvariantCultureIgnoreCase)
        {
             {"Burlington", 0.0675}
            ,{"Graham", 0.0675}
            ,{"Mebane",  0.0675}
            ,{"Elon",  0.0675}
            ,{"Haw River",  0.0675}
            ,{"Snow Camp",  0.0675}
            ,{"Alamance",  0.0675}
            ,{"Altamahaw",  0.0675}
            ,{"Saxapahaw",  0.0675}
            ,{"Swepsonville",  0.0675}
            ,{"Taylorsville",  0.0700}
            ,{"Hiddenite",  0.0700}
            ,{"Stony Point",  0.0700}
            ,{"Scotts",  0.0675}
            ,{"Sparta",  0.0675}
            ,{"Ennice",  0.0675}
            ,{"Laurel Springs",  0.0675}
            ,{"Glade Valley" ,  0.0675}
            ,{"Piney Creek",  0.0675}
            ,{"Roaring Gap",  0.0675}
            ,{"Wadesboro",  0.0700}
            ,{"Polkton",  0.0700}
            ,{"Peachland",  0.0700}
            ,{"Morven",  0.0700}
            ,{"Lilesville",  0.0700}
            ,{"Ansonville",  0.0700}
            ,{"Mc Farlan",  0.0700}
            ,{"West Jefferson	",  0.0700}
            ,{"Jefferson",  0.0700}
            ,{"Lansing",  0.0700}
            ,{"Fleetwood",  0.0700}
            ,{"Crumpler" ,  0.0700}
            ,{"Creston",  0.0700}
            ,{"Todd" ,  0.0700}
            ,{"Warrensville" ,  0.0700}
            ,{"Grassy Creek" ,  0.0700}
            ,{"Scottville",  0.0700}
            ,{"Glendale Springs",  0.0700}
            ,{"Newland",  0.0675}
            ,{"Banner Elk",  0.0675}
            ,{"Elk Park" ,  0.0675}
            ,{"Linville" ,  0.0675}
            ,{"Collettsville",  0.0675}
            ,{"Crossnore",  0.0675}
            ,{"Pineola",  0.0675}
            ,{"Plumtree" ,  0.0675}
            ,{"Montezuma",  0.0675}
            ,{"Jonas Ridge",  0.0675}
            ,{"Minneapolis",  0.0675}
            ,{"Linville Falls",  0.0675}
            ,{"Washington",  0.0675}
            ,{"Chocowinity",  0.0675}
            ,{"Belhaven" ,  0.0675}
            ,{"Bath" ,  0.0675}
            ,{"Aurora",  0.0675}
            ,{"Pantego",  0.0675}
            ,{"Pinetown" ,  0.0675}
            ,{"Blounts Creek",  0.0675}
            ,{"Edward",  0.0675}
            ,{"Windsor",  0.0675}
            ,{"Aulander" ,  0.0675}
            ,{"Colerain" ,  0.0675}
            ,{"Lewiston Woodville",  0.0675}
            ,{"Merry Hill",  0.0675}
            ,{"Kelford",  0.0675}
            ,{"Powellsville" ,  0.0675}
            ,{"Roxobel",  0.0675}
            ,{"Elizabethtown",  0.0675}
            ,{"Bladenboro",  0.0675}
            ,{"Clarkton" ,  0.0675}
            ,{"Tar Heel" ,  0.0675}
            ,{"White Oak",  0.0675}
            ,{"Council",  0.0675}
            ,{"Kelly",  0.0675}
            ,{"Dublin",  0.0675}
            ,{"Leland",  0.0675}
            ,{"Southport",  0.0675}
            ,{"Supply",  0.0675}
            ,{"Calabash" ,  0.0675}
            ,{"Shallotte",  0.0675}
            ,{"Oak Island",  0.0675}
            ,{"Ocean Isle Beach" ,  0.0675}
            ,{"Bolivia",  0.0675}
            ,{"Winnabow" ,  0.0675}
            ,{"Sunset Beach" ,  0.0675}
            ,{"Ash",  0.0675}
            ,{"Longwood" ,  0.0675}
            ,{"Asheville",  0.0700}
            ,{"Candler",  0.0700}
            ,{"Weaverville",  0.0700}
            ,{"Arden",  0.0700}
            ,{"Fletcher" ,  0.0675}
            ,{"Black Mountain	",  0.0700}
            ,{"Leicester",  0.0700}
            ,{"Fairview" ,  0.0700}
            ,{"Swannanoa",  0.0700}
            ,{"Alexander",  0.0700}
            ,{"Barnardsville",  0.0700}
            ,{"Enka" ,  0.0700}
            ,{"Skyland",  0.0700}
            ,{"Montreat" ,  0.0700}
            ,{"Ridgecrest",  0.0700}
            ,{"Morganton",  0.0675}
            ,{"Connellys Springs",  0.0675}
            ,{"Valdese",  0.0675}
            ,{"Hildebran",  0.0675}
            ,{"Drexel",  0.0675}
            ,{"Glen Alpine",  0.0675}
            ,{"Icard",  0.0675}
            ,{"Rutherford College",  0.0675}
            ,{"Concord",  0.0700}
            ,{"Kannapolis",  0.0700}
            ,{"Harrisburg",  0.0700}
            ,{"Mount Pleasant",  0.0700}
            ,{"Midland",  0.0700}
            ,{"Lenoir",  0.0675}
            ,{"Granite Falls",  0.0675}
            ,{"Hudson",  0.0675}
            ,{"Patterson",  0.0675}
            ,{"Camden",  0.0675}
            ,{"South Mills",  0.0675}
            ,{"Shiloh",  0.0675}
            ,{"Newport",  0.0675}
            ,{"Morehead City",  0.0675}
            ,{"Beaufort" ,  0.0675}
            ,{"Emerald Isle" ,  0.0675}
            ,{"Atlantic Beach",  0.0675}
            ,{"Stella",  0.0700}
            ,{"Harkers Island",  0.0675}
            ,{"Gloucester",  0.0675}
            ,{"Atlantic" ,  0.0675}
            ,{"Smyrna",  0.0675}
            ,{"Davis",  0.0675}
            ,{"Stacy",  0.0675}
            ,{"Sealevel" ,  0.0675}
            ,{"Salter Path",  0.0675}
            ,{"Cedar Island" ,  0.0675}
            ,{"Marshallberg" ,  0.0675}
            ,{"Yanceyville",  0.0675}
            ,{"Pelham",  0.0675}
            ,{"Providence",  0.0675}
            ,{"Leasburg" ,  0.0675}
            ,{"Milton",  0.0675}
            ,{"Blanch",  0.0675}
            ,{"Prospect Hill",  0.0675}
            ,{"Hickory",  0.0700}
            ,{"Newton",  0.0700}
            ,{"Conover",  0.0700}
            ,{"Maiden",  0.0700}
            ,{"Claremont",  0.0700}
            ,{"Sherrills Ford",  0.0700}
            ,{"Catawba",  0.0700}
            ,{"Terrell",  0.0700}
            ,{"Pittsboro",  0.0675}
            ,{"Siler City",  0.0675}
            ,{"Bear Creek",  0.0675}
            ,{"Moncure",  0.0675}
            ,{"Goldston" ,  0.0675}
            ,{"Bennett",  0.0675}
            ,{"Gulf" ,  0.0675}
            ,{"Bonlee",  0.0675}
            ,{"Highfalls",  0.0700}
            ,{"Murphy",  0.0700}
            ,{"Andrews",  0.0700}
            ,{"Marble",  0.0700}
            ,{"Brasstown",  0.0700}
            ,{"Culberson",  0.0700}
            ,{"Edenton",  0.0675}
            ,{"Tyner",  0.0675}
            ,{"Hayesville",  0.0700}
            ,{"Warne",  0.0700}
            ,{"Shelby",  0.0675}
            ,{"Kings Mountain",  0.0675}
            ,{"Lawndale" ,  0.0675}
            ,{"Grover",  0.0675}
            ,{"Casar",  0.0675}
            ,{"Boiling Springs",  0.0675}
            ,{"Fallston" ,  0.0675}
            ,{"Polkville",  0.0675}
            ,{"Earl" ,  0.0675}
            ,{"Waco" ,  0.0675}
            ,{"Lattimore",  0.0675}
            ,{"Whiteville",  0.0675}
            ,{"Tabor City",  0.0675}
            ,{"Chadbourn",  0.0675}
            ,{"Riegelwood",  0.0675}
            ,{"Delco",  0.0675}
            ,{"Lake Waccamaw",  0.0675}
            ,{"Bolton",  0.0675}
            ,{"Clarendon",  0.0675}
            ,{"Cerro Gordo",  0.0675}
            ,{"Nakina",  0.0675}
            ,{"Evergreen",  0.0675}
            ,{"Hallsboro",  0.0675}
            ,{"Fair Bluff",  0.0675}
            ,{"Brunswick",  0.0675}
            ,{"New Bern" ,  0.0675}
            ,{"Havelock" ,  0.0675}
            ,{"Vanceboro",  0.0675}
            ,{"Cove City",  0.0675}
            ,{"Cherry Point" ,  0.0675}
            ,{"Dover",  0.0675}
            ,{"Ernul",  0.0675}
            ,{"Bridgeton",  0.0675}
            ,{"Fayetteville" ,  0.0700}
            ,{"Hope Mills",  0.0700}
            ,{"Fort Bragg",  0.0700}
            ,{"Stedman",  0.0700}
            ,{"Linden",  0.0700}
            ,{"Wade" ,  0.0700}
            ,{"Pope Army Airfield",  0.0700}
            ,{"Falcon",  0.0700}
            ,{"Cumberland",  0.0700}
            ,{"Moyock",  0.0675}
            ,{"Grandy",  0.0675}
            ,{"Knotts Island",  0.0675}
            ,{"Shawboro" ,  0.0675}
            ,{"Currituck",  0.0675}
            ,{"Powells Point",  0.0675}
            ,{"Jarvisburg",  0.0675}
            ,{"Corolla",  0.0675}
            ,{"Aydlett",  0.0675}
            ,{"Harbinger",  0.0675}
            ,{"Barco",  0.0675}
            ,{"Coinjock" ,  0.0675}
            ,{"Point Harbor" ,  0.0675}
            ,{"Poplar Branch",  0.0675}
            ,{"Maple",  0.0675}
            ,{"Kill Devil Hills" ,  0.0675}
            ,{"Kitty Hawk",  0.0675}
            ,{"Manteo",  0.0675}
            ,{"Nags Head",  0.0675}
            ,{"Wanchese" ,  0.0675}
            ,{"Buxton",  0.0675}
            ,{"Manns Harbor" ,  0.0675}
            ,{"Avon" ,  0.0675}
            ,{"Hatteras" ,  0.0675}
            ,{"Frisco",  0.0675}
            ,{"Rodanthe" ,  0.0675}
            ,{"Stumpy Point" ,  0.0675}
            ,{"Lexington",  0.0700}
            ,{"Thomasville",  0.0700}
            ,{"Denton",  0.0700}
            ,{"Linwood",  0.0700}
            ,{"Welcome",  0.0700}
            ,{"Southmont",  0.0700}
            ,{"Wallburg" ,  0.0700}
            ,{"Mocksville",  0.0675}
            ,{"Advance",  0.0675}
            ,{"Cooleemee",  0.0675}
            ,{"Mount Olive",  0.0675}
            ,{"Wallace",  0.0700}
            ,{"Beulaville",  0.0700}
            ,{"Warsaw",  0.0700}
            ,{"Rose Hill",  0.0700}
            ,{"Faison",  0.0700}
            ,{"Kenansville",  0.0700}
            ,{"Magnolia" ,  0.0700}
            ,{"Teachey",  0.0700}
            ,{"Chinquapin",  0.0700}
            ,{"Albertson",  0.0700}
            ,{"Calypso",  0.0700}
            ,{"Durham",  0.0750}
            ,{"Bahama",  0.0750}
            ,{"Rocky Mount",  0.0700}
            ,{"Tarboro",  0.0700}
            ,{"Pinetops" ,  0.0700}
            ,{"Macclesfield" ,  0.0700}
            ,{"Hobgood",  0.0700}
            ,{"Conetoe",  0.0700}
            ,{"Speed",  0.0700}
            ,{"Winston Salem",  0.0675}
            ,{"Kernersville" ,  0.0675}
            ,{"Clemmons" ,  0.0675}
            ,{"Lewisville",  0.0675}
            ,{"Pfafftown",  0.0675}
            ,{"Rural Hall",  0.0675}
            ,{"Walkertown",  0.0675}
            ,{"Tobaccoville" ,  0.0675}
            ,{"Belews Creek" ,  0.0675}
            ,{"Bethania" ,  0.0675}
            ,{"Louisburg",  0.0675}
            ,{"Youngsville",  0.0675}
            ,{"Franklinton",  0.0675}
            ,{"Castalia" ,  0.0675}
            ,{"Bunn" ,  0.0675}
            ,{"Gastonia" ,  0.0700}
            ,{"Belmont",  0.0700}
            ,{"Mount Holly",  0.0700}
            ,{"Dallas",  0.0700}
            ,{"Stanley",  0.0700}
            ,{"Cherryville",  0.0700}
            ,{"Bessemer City",  0.0700}
            ,{"Lowell",  0.0700}
            ,{"Cramerton",  0.0700}
            ,{"Alexis",  0.0700}
            ,{"Mc Adenville" ,  0.0700}
            ,{"High Shoals",  0.0700}
            ,{"Gates",  0.0675}
            ,{"Corapeake",  0.0675}
            ,{"Sunbury",  0.0675}
            ,{"Eure" ,  0.0675}
            ,{"Gatesville",  0.0675}
            ,{"Hobbsville",  0.0675}
            ,{"Roduco",  0.0675}
            ,{"Robbinsville" ,  0.0700}
            ,{"Almond",  0.0700}
            ,{"Fontana Dam",  0.0700}
            ,{"Oxford",  0.0675}
            ,{"Creedmoor",  0.0675}
            ,{"Butner",  0.0675}
            ,{"Stem" ,  0.0675}
            ,{"Bullock",  0.0675}
            ,{"Stovall",  0.0675}
            ,{"Snow Hill",  0.0700}
            ,{"Walstonburg",  0.0700}
            ,{"Hookerton",  0.0700}
            ,{"Maury",  0.0700}
            ,{"Greensboro",  0.0675}
            ,{"High Point",  0.0675}
            ,{"Jamestown",  0.0675}
            ,{"Summerfield",  0.0675}
            ,{"Gibsonville",  0.0675}
            ,{"Browns Summit",  0.0675}
            ,{"Mc Leansville",  0.0675}
            ,{"Oak Ridge",  0.0675}
            ,{"Pleasant Garden",  0.0675}
            ,{"Whitsett" ,  0.0675}
            ,{"Colfax",  0.0675}
            ,{"Julian",  0.0675}
            ,{"Sedalia",  0.0675}
            ,{"Roanoke Rapids",  0.0700}
            ,{"Enfield",  0.0700}
            ,{"Scotland Neck",  0.0700}
            ,{"Halifax",  0.0700}
            ,{"Hollister",  0.0700}
            ,{"Weldon",  0.0700}
            ,{"Tillery",  0.0700}
            ,{"Dunn" ,  0.0700}
            ,{"Spring Lake",  0.0700}
            ,{"Angier",  0.0700}
            ,{"Cameron",  0.0700}
            ,{"Lillington",  0.0700}
            ,{"Erwin",  0.0700}
            ,{"Broadway" ,  0.0700}
            ,{"Coats",  0.0700}
            ,{"Bunnlevel",  0.0700}
            ,{"Buies Creek",  0.0700}
            ,{"Olivia",  0.0700}
            ,{"Mamers",  0.0700}
            ,{"Kipling",  0.0700}
            ,{"Waynesville",  0.0700}
            ,{"Canton",  0.0700}
            ,{"Clyde",  0.0700}
            ,{"Maggie Valley",  0.0700}
            ,{"Lake Junaluska",  0.0700}
            ,{"Hazelwood",  0.0700}
            ,{"Hendersonville",  0.0675}
            ,{"Flat Rock",  0.0675}
            ,{"Mills River",  0.0675}
            ,{"Etowah",  0.0675}
            ,{"Horse Shoe",  0.0675}
            ,{"East Flat Rock",  0.0675}
            ,{"Zirconia" ,  0.0675}
            ,{"Dana" ,  0.0675}
            ,{"Mountain Home",  0.0675}
            ,{"Edneyville",  0.0675}
            ,{"Gerton",  0.0675}
            ,{"Naples",  0.0675}
            ,{"Tuxedo",  0.0675}
            ,{"Bat Cave" ,  0.0675}
            ,{"Ahoskie",  0.0700}
            ,{"Murfreesboro" ,  0.0700}
            ,{"Como" ,  0.0700}
            ,{"Winton",  0.0700}
            ,{"Cofield",  0.0700}
            ,{"Harrellsville",  0.0700}
            ,{"Raeford",  0.0675}
            ,{"Engelhard",  0.0675}
            ,{"Ocracoke" ,  0.0675}
            ,{"Swanquarter",  0.0675}
            ,{"Fairfield",  0.0675}
            ,{"Scranton" ,  0.0675}
            ,{"Mooresville",  0.0675}
            ,{"Statesville",  0.0675}
            ,{"Troutman" ,  0.0675}
            ,{"Harmony",  0.0675}
            ,{"Olin" ,  0.0675}
            ,{"Union Grove",  0.0675}
            ,{"Turnersburg",  0.0675}
            ,{"Mount Mourne" ,  0.0675}
            ,{"Barium Springs",  0.0675}
            ,{"Sylva",  0.0700}
            ,{"Cullowhee",  0.0700}
            ,{"Whittier" ,  0.0700}
            ,{"Cashiers" ,  0.0700}
            ,{"Tuckasegee",  0.0700}
            ,{"Dillsboro",  0.0700}
            ,{"Sapphire" ,  0.0700}
            ,{"Webster",  0.0700}
            ,{"Glenville",  0.0700}
            ,{"Balsam",  0.0700}
            ,{"Clayton",  0.0675}
            ,{"Smithfield	",  0.0675}
            ,{"Selma",  0.0675}
            ,{"Benson",  0.0675}
            ,{"Four Oaks",  0.0675}
            ,{"Kenly",  0.0675}
            ,{"Princeton",  0.0675}
            ,{"Pine Level",  0.0675}
            ,{"Micro",  0.0675}
            ,{"Wilsons Mills",  0.0675}
            ,{"Trenton",  0.0700}
            ,{"Pollocksville",  0.0700}
            ,{"Comfort",  0.0700}
            ,{"Sanford",  0.0700}
            ,{"Lemon Springs",  0.0700}
            ,{"Kinston",  0.0675}
            ,{"La Grange",  0.0675}
            ,{"Pink Hill",  0.0700}
            ,{"Deep Run" ,  0.0675}
            ,{"Lincolnton",  0.0700}
            ,{"Denver",  0.0700}
            ,{"Vale" ,  0.0700}
            ,{"Iron Station" ,  0.0700}
            ,{"Crouse",  0.0700}
            ,{"Franklin" ,  0.0675}
            ,{"Highlands",  0.0675}
            ,{"Otto" ,  0.0675}
            ,{"Topton",  0.0675}
            ,{"Scaly Mountain",  0.0675}
            ,{"Marshall" ,  0.0675}
            ,{"Mars Hill",  0.0675}
            ,{"Hot Springs",  0.0675}
            ,{"Williamston",  0.0700}
            ,{"Robersonville",  0.0700}
            ,{"Jamesville",  0.0700}
            ,{"Oak City" ,  0.0700}
            ,{"Hamilton" ,  0.0700}
            ,{"Hassell",  0.0700}
            ,{"Parmele",  0.0700}
            ,{"Everetts" ,  0.0700}
            ,{"Marion",  0.0675}
            ,{"Nebo" ,  0.0675}
            ,{"Old Fort" ,  0.0675}
            ,{"Charlotte",  0.0725}
            ,{"Huntersville" ,  0.0725}
            ,{"Cornelius",  0.0725}
            ,{"Davidson" ,  0.0725}
            ,{"Pineville",  0.0725}
            ,{"Newell",  0.0725}
            ,{"Paw Creek",  0.0725}
            ,{"Spruce Pine",  0.0675}
            ,{"Bakersville",  0.0675}
            ,{"Penland",  0.0675}
            ,{"Little Switzerland",  0.0675}
            ,{"Troy" ,  0.0700}
            ,{"Mount Gilead" ,  0.0700}
            ,{"Biscoe",  0.0700}
            ,{"Candor",  0.0700}
            ,{"Star" ,  0.0700}
            ,{"Ether",  0.0700}
            ,{"Pinehurst",  0.0700}
            ,{"Carthage" ,  0.0700}
            ,{"Southern Pines",  0.0700}
            ,{"Aberdeen" ,  0.0700}
            ,{"West End" ,  0.0700}
            ,{"Robbins",  0.0700}
            ,{"Vass" ,  0.0700}
            ,{"Pinebluff",  0.0700}
            ,{"Jackson Springs",  0.0700}
            ,{"Eagle Springs",  0.0700}
            ,{"Lakeview" ,  0.0700}
            ,{"Nashville",  0.0675}
            ,{"Spring Hope",  0.0675}
            ,{"Middlesex",  0.0675}
            ,{"Bailey",  0.0675}
            ,{"Whitakers",  0.0675}
            ,{"Battleboro",  0.0675}
            ,{"Sharpsburg",  0.0675}
            ,{"Red Oak",  0.0675}
            ,{"Wilmington",  0.0700}
            ,{"Castle Hayne" ,  0.0700}
            ,{"Carolina Beach",  0.0700}
            ,{"Wrightsville Beach",  0.0700}
            ,{"Kure Beach",  0.0700}
            ,{"Gaston",  0.0675}
            ,{"Garysburg",  0.0675}
            ,{"Conway",  0.0675}
            ,{"Rich Square",  0.0675}
            ,{"Jackson",  0.0675}
            ,{"Henrico",  0.0675}
            ,{"Woodland" ,  0.0675}
            ,{"Seaboard" ,  0.0675}
            ,{"Pleasant Hill",  0.0675}
            ,{"Pendleton",  0.0675}
            ,{"Severn",  0.0675}
            ,{"Potecasi" ,  0.0675}
            ,{"Margarettsville",  0.0675}
            ,{"Jacksonville" ,  0.0700}
            ,{"Hubert",  0.0700}
            ,{"Richlands",  0.0700}
            ,{"Swansboro",  0.0700}
            ,{"Sneads Ferry" ,  0.0700}
            ,{"Camp Lejeune" ,  0.0700}
            ,{"Holly Ridge",  0.0675}
            ,{"Midway Park",  0.0700}
            ,{"Maysville",  0.0700}
            ,{"Tarawa Terrace",  0.0700}
            ,{"Mccutcheon Field" ,  0.0700}
            ,{"Chapel Hill",  0.0750}
            ,{"Hillsborough" ,  0.0750}
            ,{"Carrboro" ,  0.0750}
            ,{"Efland",  0.0750}
            ,{"Cedar Grove",  0.0750}
            ,{"Oriental" ,  0.0675}
            ,{"Bayboro",  0.0675}
            ,{"Grantsboro",  0.0675}
            ,{"Arapahoe" ,  0.0675}
            ,{"Merritt",  0.0675}
            ,{"Lowland",  0.0675}
            ,{"Alliance" ,  0.0675}
            ,{"Hobucken" ,  0.0675}
            ,{"Stonewall",  0.0675}
            ,{"Vandemere",  0.0675}
            ,{"Elizabeth City",  0.0700}
            ,{"Hampstead",  0.0675}
            ,{"Rocky Point",  0.0675}
            ,{"Burgaw",  0.0675}
            ,{"Willard",  0.0675}
            ,{"Maple Hill",  0.0675}
            ,{"Currie",  0.0675}
            ,{"Atkinson" ,  0.0675}
            ,{"Hertford" ,  0.0675}
            ,{"Belvidere",  0.0675}
            ,{"Winfall",  0.0675}
            ,{"Roxboro",  0.0675}
            ,{"Timberlake",  0.0675}
            ,{"Rougemont",  0.0750}
            ,{"Hurdle Mills" ,  0.0675}
            ,{"Semora",  0.0675}
            ,{"Greenville",  0.0700}
            ,{"Winterville",  0.0700}
            ,{"Ayden",  0.0700}
            ,{"Farmville",  0.0700}
            ,{"Grifton",  0.0700}
            ,{"Grimesland",  0.0700}
            ,{"Bethel",  0.0700}
            ,{"Fountain" ,  0.0700}
            ,{"Stokes",  0.0700}
            ,{"Saratoga" ,  0.0675}
            ,{"Simpson",  0.0700}
            ,{"Falkland" ,  0.0700}
            ,{"Bellarthur",  0.0700}
            ,{"Columbus" ,  0.0675}
            ,{"Tryon",  0.0675}
            ,{"Mill Spring",  0.0675}
            ,{"Saluda",  0.0675}
            ,{"Lynn" ,  0.0675}
            ,{"Asheboro" ,  0.0700}
            ,{"Randleman",  0.0700}
            ,{"Trinity",  0.0700}
            ,{"Liberty",  0.0700}
            ,{"Ramseur",  0.0700}
            ,{"Sophia",  0.0700}
            ,{"Seagrove" ,  0.0700}
            ,{"Franklinville",  0.0700}
            ,{"Climax",  0.0700}
            ,{"Staley",  0.0700}
            ,{"Cedar Falls",  0.0700}
            ,{"Hamlet",  0.0675}
            ,{"Ellerbe",  0.0675}
            ,{"Rockingham",  0.0675}
            ,{"Marston",  0.0675}
            ,{"Cordova",  0.0675}
            ,{"Hoffman",  0.0675}
            ,{"Norman",  0.0675}
            ,{"Pembroke" ,  0.0700}
            ,{"Maxton",  0.0700}
            ,{"Saint Pauls",  0.0700}
            ,{"Lumberton",  0.0700}
            ,{"Red Springs",  0.0700}
            ,{"Fairmont" ,  0.0700}
            ,{"Rowland",  0.0700}
            ,{"Parkton",  0.0700}
            ,{"Shannon",  0.0700}
            ,{"Lumber Bridge",  0.0700}
            ,{"Orrum",  0.0700}
            ,{"Rex",  0.0700}
            ,{"Marietta" ,  0.0700}
            ,{"Proctorville" ,  0.0700}
            ,{"Reidsville",  0.0700}
            ,{"Eden" ,  0.0700}
            ,{"Madison",  0.0700}
            ,{"Stoneville",  0.0700}
            ,{"Stokesdale",  0.0700}
            ,{"Mayodan",  0.0700}
            ,{"Ruffin",  0.0700}
            ,{"Wentworth",  0.0700}
            ,{"Salisbury",  0.0700}
            ,{"China Grove",  0.0700}
            ,{"Rockwell" ,  0.0700}
            ,{"Cleveland",  0.0700}
            ,{"Landis",  0.0700}
            ,{"Spencer",  0.0700}
            ,{"Gold Hill",  0.0700}
            ,{"Woodleaf" ,  0.0700}
            ,{"Mount Ulla",  0.0700}
            ,{"Granite Quarry",  0.0700}
            ,{"Faith",  0.0700}
            ,{"East Spencer" ,  0.0700}
            ,{"Rutherfordton",  0.0700}
            ,{"Forest City",  0.0700}
            ,{"Ellenboro",  0.0700}
            ,{"Mooresboro",  0.0675}
            ,{"Bostic",  0.0700}
            ,{"Spindale" ,  0.0700}
            ,{"Lake Lure",  0.0700}
            ,{"Union Mills",  0.0700}
            ,{"Henrietta",  0.0700}
            ,{"Cliffside",  0.0700}
            ,{"Caroleen" ,  0.0700}
            ,{"Harris",  0.0700}
            ,{"Chimney Rock" ,  0.0700}
            ,{"Roseboro" ,  0.0700}
            ,{"Newton Grove" ,  0.0700}
            ,{"Autryville",  0.0700}
            ,{"Clinton",  0.0700}
            ,{"Garland",  0.0700}
            ,{"Salemburg",  0.0700}
            ,{"Godwin",  0.0700}
            ,{"Harrells" ,  0.0700}
            ,{"Turkey",  0.0700}
            ,{"Ivanhoe",  0.0700}
            ,{"Laurinburg",  0.0675}
            ,{"Laurel Hill",  0.0675}
            ,{"Wagram",  0.0675}
            ,{"Gibson",  0.0675}
            ,{"Albemarle",  0.0700}
            ,{"Norwood",  0.0700}
            ,{"New London",  0.0700}
            ,{"Oakboro",  0.0700}
            ,{"Locust",  0.0700}
            ,{"Stanfield",  0.0700}
            ,{"Richfield",  0.0700}
            ,{"Badin",  0.0700}
            ,{"Misenheimer",  0.0700}
            ,{"King" ,  0.0675}
            ,{"Walnut Cove",  0.0675}
            ,{"Germanton",  0.0675}
            ,{"Westfield",  0.0675}
            ,{"Sandy Ridge",  0.0675}
            ,{"Danbury",  0.0675}
            ,{"Lawsonville",  0.0675}
            ,{"Pine Hall",  0.0675}
            ,{"Mount Airy",  0.0700}
            ,{"Elkin",  0.0700}
            ,{"Dobson",  0.0700}
            ,{"Pilot Mountain",  0.0700}
            ,{"Pinnacle" ,  0.0675}
            ,{"State Road",  0.0700}
            ,{"Lowgap",  0.0700}
            ,{"Ararat",  0.0700}
            ,{"Thurmond" ,  0.0700}
            ,{"Siloam",  0.0700}
            ,{"Toast",  0.0700}
            ,{"White Plains" ,  0.0700}
            ,{"Bryson City",  0.0700}
            ,{"Cherokee" ,  0.0700}
            ,{"Brevard",  0.0675}
            ,{"Pisgah Forest",  0.0675}
            ,{"Rosman",  0.0675}
            ,{"Lake Toxaway" ,  0.0675}
            ,{"Penrose",  0.0675}
            ,{"Cedar Mountain",  0.0675}
            ,{"Balsam Grove" ,  0.0675}
            ,{"Columbia" ,  0.0675}
            ,{"Monroe",  0.0675}
            ,{"Waxhaw",  0.0675}
            ,{"Indian Trail" ,  0.0675}
            ,{"Matthews" ,  0.0675}
            ,{"Marshville",  0.0675}
            ,{"Wingate",  0.0675}
            ,{"Mineral Springs",  0.0675}
            ,{"Henderson",  0.0675}
            ,{"Kittrell" ,  0.0675}
            ,{"Townsville",  0.0675}
            ,{"Middleburg",  0.0675}
            ,{"Raleigh",  0.0725}
            ,{"Cary" ,  0.0725}
            ,{"Wake Forest",  0.0725}
            ,{"Littleton",  0.0700}
            ,{"Warrenton",  0.0675}
            ,{"Norlina",  0.0675}
            ,{"Manson",  0.0675}
            ,{"Macon",  0.0675}
            ,{"Wise" ,  0.0675}
            ,{"Vaughan",  0.0675}
            ,{"Ridgeway" ,  0.0675}
            ,{"Plymouth" ,  0.0675}
            ,{"Roper",  0.0675}
            ,{"Creswell" ,  0.0675}
            ,{"Blowing Rock" ,  0.0675}
            ,{"Vilas",  0.0675}
            ,{"Deep Gap" ,  0.0675}
            ,{"Zionville",  0.0675}
            ,{"Sugar Grove",  0.0675}
            ,{"Boone",  0.0675}
            ,{"Valle Crucis" ,  0.0675}
            ,{"Goldsboro",  0.0675}
            ,{"Pikeville",  0.0675}
            ,{"Dudley",  0.0675}
            ,{"Seven Springs",  0.0675}
            ,{"Fremont",  0.0675}
            ,{"Wilkesboro",  0.0700}
            ,{"Millers Creek",  0.0700}
            ,{"Hays" ,  0.0700}
            ,{"Moravian Falls",  0.0700}
            ,{"Roaring River",  0.0700}
            ,{"Ronda",  0.0700}
            ,{"Purlear",  0.0700}
            ,{"Boomer",  0.0700}
            ,{"Traphill" ,  0.0700}
            ,{"Ferguson" ,  0.0700}
            ,{"Mc Grady" ,  0.0700}
            ,{"North Wilkesboro" ,  0.0700}
            ,{"Wilson",  0.0675}
            ,{"Elm City" ,  0.0675}
            ,{"Lucama",  0.0675}
            ,{"Stantonsburg" ,  0.0700}
            ,{"Sims" ,  0.0675}
            ,{"Black Creek",  0.0675}
            ,{"Yadkinville",  0.0675}
            ,{"East Bend",  0.0675}
            ,{"Hamptonville" ,  0.0675}
            ,{"Jonesville",  0.0675}
            ,{"Boonville",  0.0675}
            ,{"Burnsville",  0.0675}
            ,{"Green Mountain",  0.0675}
            ,{"Micaville",  0.0675}
        };
    }
}