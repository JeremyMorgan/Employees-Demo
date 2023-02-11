using Microsoft.EntityFrameworkCore;

namespace Employees.Data
{
    public class EmployeeDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("EmployeeDB"));
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee");

            modelBuilder.Entity<Employee>()
                    .HasData(
                new Employee { Id = 1, FirstName = "Nonie", LastName = "Morgue", Email = "nmorgue0@disqus.com", Department = "Research and Development", Avatar = "https://robohash.org/autautea.png?size=100x100&set=set1" },
                new Employee { Id = 2, FirstName = "Krishna", LastName = "Lowe", Email = "klowe1@nymag.com", Department = "Research and Development", Avatar = "https://robohash.org/saepeadipiscifugit.png?size=100x100&set=set1" },
                new Employee { Id = 3, FirstName = "Orville", LastName = "Williamson", Email = "owilliamson2@washingtonpost.com", Department = "Research and Development", Avatar = "https://robohash.org/atquerepudiandaecorporis.png?size=100x100&set=set1" },
                new Employee { Id = 4, FirstName = "Dwayne", LastName = "Itzkovici", Email = "ditzkovici3@phpbb.com", Department = "Product Management", Avatar = "https://robohash.org/liberotemporibusalias.png?size=100x100&set=set1" },
                new Employee { Id = 5, FirstName = "Shelbi", LastName = "Jerisch", Email = "sjerisch4@craigslist.org", Department = "Research and Development", Avatar = "https://robohash.org/enimsapienteillum.png?size=100x100&set=set1" },
                new Employee { Id = 6, FirstName = "Jerrilee", LastName = "Witcherley", Email = "jwitcherley5@1und1.de", Department = "Services", Avatar = "https://robohash.org/omnisillumnostrum.png?size=100x100&set=set1" },
                new Employee { Id = 7, FirstName = "Caritta", LastName = "Kobpac", Email = "ckobpac6@goo.ne.jp", Department = "Marketing", Avatar = "https://robohash.org/adipiscisequidolor.png?size=100x100&set=set1" },
                new Employee { Id = 8, FirstName = "Quincey", LastName = "McCague", Email = "qmccague7@facebook.com", Department = "Human Resources", Avatar = "https://robohash.org/aliquamquassunt.png?size=100x100&set=set1" },
                new Employee { Id = 9, FirstName = "Aharon", LastName = "Cundey", Email = "acundey8@yahoo.com", Department = "Accounting", Avatar = "https://robohash.org/eaquiserror.png?size=100x100&set=set1" },
                new Employee { Id = 10, FirstName = "Neila", LastName = "Anthill", Email = "nanthill9@posterous.com", Department = "Services", Avatar = "https://robohash.org/dolorconsecteturdeleniti.png?size=100x100&set=set1" },
                new Employee { Id = 11, FirstName = "Cinnamon", LastName = "Broader", Email = "cbroadera@theglobeandmail.com", Department = "Business Development", Avatar = "https://robohash.org/veroculpadolore.png?size=100x100&set=set1" },
                new Employee { Id = 12, FirstName = "Godfrey", LastName = "Tampin", Email = "gtampinb@example.com", Department = "Business Development", Avatar = "https://robohash.org/autveritatisquibusdam.png?size=100x100&set=set1" },
                new Employee { Id = 13, FirstName = "Olimpia", LastName = "Andrelli", Email = "oandrellic@t-online.de", Department = "Support", Avatar = "https://robohash.org/utvoluptasdolorum.png?size=100x100&set=set1" },
                new Employee { Id = 14, FirstName = "Grissel", LastName = "Ebbles", Email = "gebblesd@fema.gov", Department = "Human Resources", Avatar = "https://robohash.org/odioinqui.png?size=100x100&set=set1" },
                new Employee { Id = 15, FirstName = "Beckie", LastName = "Sutherley", Email = "bsutherleye@bing.com", Department = "Sales", Avatar = "https://robohash.org/saepedelenitivoluptas.png?size=100x100&set=set1" },
                new Employee { Id = 16, FirstName = "Drusie", LastName = "Schohier", Email = "dschohierf@dion.ne.jp", Department = "Sales", Avatar = "https://robohash.org/aspernaturautdicta.png?size=100x100&set=set1" },
                new Employee { Id = 17, FirstName = "Aida", LastName = "Heister", Email = "aheisterg@soup.io", Department = "Sales", Avatar = "https://robohash.org/dolornobisratione.png?size=100x100&set=set1" },
                new Employee { Id = 18, FirstName = "Valentia", LastName = "Leake", Email = "vleakeh@umn.edu", Department = "Services", Avatar = "https://robohash.org/estnihilsuscipit.png?size=100x100&set=set1" },
                new Employee { Id = 19, FirstName = "Octavius", LastName = "Gellately", Email = "ogellatelyi@spotify.com", Department = "Training", Avatar = "https://robohash.org/abperspiciatismagnam.png?size=100x100&set=set1" },
                new Employee { Id = 20, FirstName = "Erwin", LastName = "Mandy", Email = "emandyj@webs.com", Department = "Product Management", Avatar = "https://robohash.org/blanditiisvoluptasrerum.png?size=100x100&set=set1" },
                new Employee { Id = 21, FirstName = "Armand", LastName = "Devenport", Email = "adevenportk@google.fr", Department = "Engineering", Avatar = "https://robohash.org/auteavel.png?size=100x100&set=set1" },
                new Employee { Id = 22, FirstName = "Bartel", LastName = "Torel", Email = "btorell@mit.edu", Department = "Research and Development", Avatar = "https://robohash.org/consequuntureveniethic.png?size=100x100&set=set1" },
                new Employee { Id = 23, FirstName = "Auberta", LastName = "Ludgate", Email = "aludgatem@ning.com", Department = "Research and Development", Avatar = "https://robohash.org/fugitmagnamhic.png?size=100x100&set=set1" },
                new Employee { Id = 24, FirstName = "Claudian", LastName = "Sendall", Email = "csendalln@bizjournals.com", Department = "Support", Avatar = "https://robohash.org/voluptatumetet.png?size=100x100&set=set1" },
                new Employee { Id = 25, FirstName = "Saw", LastName = "Darrell", Email = "sdarrello@auda.org.au", Department = "Engineering", Avatar = "https://robohash.org/cupiditateestsoluta.png?size=100x100&set=set1" },
                new Employee { Id = 26, FirstName = "Arv", LastName = "Narracott", Email = "anarracottp@dedecms.com", Department = "Research and Development", Avatar = "https://robohash.org/quosconsequaturqui.png?size=100x100&set=set1" },
                new Employee { Id = 27, FirstName = "Silvia", LastName = "Clouston", Email = "scloustonq@ow.ly", Department = "Sales", Avatar = "https://robohash.org/temporibusperspiciatiscommodi.png?size=100x100&set=set1" },
                new Employee { Id = 28, FirstName = "Fabio", LastName = "Artist", Email = "fartistr@fda.gov", Department = "Support", Avatar = "https://robohash.org/eoseosdoloremque.png?size=100x100&set=set1" },
                new Employee { Id = 29, FirstName = "Eldredge", LastName = "Lent", Email = "elents@wikimedia.org", Department = "Sales", Avatar = "https://robohash.org/nihiloptiout.png?size=100x100&set=set1" },
                new Employee { Id = 30, FirstName = "Arlin", LastName = "Goodlett", Email = "agoodlettt@yellowbook.com", Department = "Business Development", Avatar = "https://robohash.org/solutaarchitectovoluptate.png?size=100x100&set=set1" },
                new Employee { Id = 31, FirstName = "Fenelia", LastName = "Keyse", Email = "fkeyseu@mac.com", Department = "Legal", Avatar = "https://robohash.org/teneturquidemexercitationem.png?size=100x100&set=set1" },
                new Employee { Id = 32, FirstName = "Merilyn", LastName = "Shawl", Email = "mshawlv@is.gd", Department = "Training", Avatar = "https://robohash.org/eligenditotamdelectus.png?size=100x100&set=set1" },
                new Employee { Id = 33, FirstName = "Maryellen", LastName = "Wadelin", Email = "mwadelinw@bravesites.com", Department = "Accounting", Avatar = "https://robohash.org/dolorevoluptatibusaut.png?size=100x100&set=set1" },
                new Employee { Id = 34, FirstName = "Blondie", LastName = "Vanyukov", Email = "bvanyukovx@vinaora.com", Department = "Sales", Avatar = "https://robohash.org/delenitiomnisperferendis.png?size=100x100&set=set1" },
                new Employee { Id = 35, FirstName = "Leon", LastName = "Liccardo", Email = "lliccardoy@unicef.org", Department = "Engineering", Avatar = "https://robohash.org/nostrumharumeveniet.png?size=100x100&set=set1" },
                new Employee { Id = 36, FirstName = "Theodosia", LastName = "Burney", Email = "tburneyz@mac.com", Department = "Engineering", Avatar = "https://robohash.org/corporisquibusdamnisi.png?size=100x100&set=set1" },
                new Employee { Id = 37, FirstName = "Tiffany", LastName = "Benedyktowicz", Email = "tbenedyktowicz10@indiatimes.com", Department = "Accounting", Avatar = "https://robohash.org/laudantiumillorepellendus.png?size=100x100&set=set1" },
                new Employee { Id = 38, FirstName = "Salomon", LastName = "Wathey", Email = "swathey11@fc2.com", Department = "Business Development", Avatar = "https://robohash.org/similiquerepellatitaque.png?size=100x100&set=set1" },
                new Employee { Id = 39, FirstName = "Fidelio", LastName = "Meineking", Email = "fmeineking12@cbsnews.com", Department = "Sales", Avatar = "https://robohash.org/utmaximeet.png?size=100x100&set=set1" },
                new Employee { Id = 40, FirstName = "Ford", LastName = "De Micoli", Email = "fdemicoli13@earthlink.net", Department = "Support", Avatar = "https://robohash.org/doloresomnisaut.png?size=100x100&set=set1" },
                new Employee { Id = 41, FirstName = "Bridie", LastName = "Stebbings", Email = "bstebbings14@bbc.co.uk", Department = "Accounting", Avatar = "https://robohash.org/nostrumdoloremqueillum.png?size=100x100&set=set1" },
                new Employee { Id = 42, FirstName = "Theressa", LastName = "Karpets", Email = "tkarpets15@cmu.edu", Department = "Business Development", Avatar = "https://robohash.org/porroenimdolorem.png?size=100x100&set=set1" },
                new Employee { Id = 43, FirstName = "Twyla", LastName = "Leivesley", Email = "tleivesley16@prlog.org", Department = "Services", Avatar = "https://robohash.org/earumquiaest.png?size=100x100&set=set1" },
                new Employee { Id = 44, FirstName = "Alane", LastName = "Croney", Email = "acroney17@purevolume.com", Department = "Product Management", Avatar = "https://robohash.org/voluptatevoluptatemexcepturi.png?size=100x100&set=set1" },
                new Employee { Id = 45, FirstName = "Althea", LastName = "Urrey", Email = "aurrey18@seesaa.net", Department = "Sales", Avatar = "https://robohash.org/possimusvoluptatesquas.png?size=100x100&set=set1" },
                new Employee { Id = 46, FirstName = "Desiri", LastName = "Phifer", Email = "dphifer19@yale.edu", Department = "Business Development", Avatar = "https://robohash.org/magnamaliasveritatis.png?size=100x100&set=set1" },
                new Employee { Id = 47, FirstName = "Cicily", LastName = "Meecher", Email = "cmeecher1a@walmart.com", Department = "Services", Avatar = "https://robohash.org/idquaesint.png?size=100x100&set=set1" },
                new Employee { Id = 48, FirstName = "Harriott", LastName = "Upstone", Email = "hupstone1b@bloglines.com", Department = "Business Development", Avatar = "https://robohash.org/magnipariaturdolor.png?size=100x100&set=set1" },
                new Employee { Id = 49, FirstName = "Cloe", LastName = "Esler", Email = "cesler1c@reddit.com", Department = "Marketing", Avatar = "https://robohash.org/quaevelitoccaecati.png?size=100x100&set=set1" },
                new Employee { Id = 50, FirstName = "Matelda", LastName = "Forsdike", Email = "mforsdike1d@skyrock.com", Department = "Training", Avatar = "https://robohash.org/cumqueipsamiste.png?size=100x100&set=set1" },
                new Employee { Id = 51, FirstName = "Deirdre", LastName = "Trigwell", Email = "dtrigwell1e@canalblog.com", Department = "Services", Avatar = "https://robohash.org/similiqueatqueeos.png?size=100x100&set=set1" },
                new Employee { Id = 52, FirstName = "Edgar", LastName = "de Mendoza", Email = "edemendoza1f@latimes.com", Department = "Legal", Avatar = "https://robohash.org/impeditnesciuntomnis.png?size=100x100&set=set1" },
                new Employee { Id = 53, FirstName = "Neely", LastName = "McNicol", Email = "nmcnicol1g@i2i.jp", Department = "Legal", Avatar = "https://robohash.org/quodeaunde.png?size=100x100&set=set1" },
                new Employee { Id = 54, FirstName = "Henrik", LastName = "Finding", Email = "hfinding1h@dell.com", Department = "Human Resources", Avatar = "https://robohash.org/cumcorruptimollitia.png?size=100x100&set=set1" },
                new Employee { Id = 55, FirstName = "Nevil", LastName = "Brodest", Email = "nbrodest1i@surveymonkey.com", Department = "Human Resources", Avatar = "https://robohash.org/voluptatumoptiominima.png?size=100x100&set=set1" },
                new Employee { Id = 56, FirstName = "Bartholemy", LastName = "Murr", Email = "bmurr1j@salon.com", Department = "Business Development", Avatar = "https://robohash.org/delectusnumquamnihil.png?size=100x100&set=set1" },
                new Employee { Id = 57, FirstName = "Kalil", LastName = "Scragg", Email = "kscragg1k@gov.uk", Department = "Product Management", Avatar = "https://robohash.org/aliaseteaque.png?size=100x100&set=set1" },
                new Employee { Id = 58, FirstName = "Abigail", LastName = "Cavalier", Email = "acavalier1l@europa.eu", Department = "Product Management", Avatar = "https://robohash.org/iustoundeperspiciatis.png?size=100x100&set=set1" },
                new Employee { Id = 59, FirstName = "Zacharie", LastName = "Lambert-Ciorwyn", Email = "zlambertciorwyn1m@merriam-webster.com", Department = "Accounting", Avatar = "https://robohash.org/inipsumnihil.png?size=100x100&set=set1" },
                new Employee { Id = 60, FirstName = "Wallis", LastName = "Sturges", Email = "wsturges1n@nytimes.com", Department = "Training", Avatar = "https://robohash.org/omnisprovidentaperiam.png?size=100x100&set=set1" },
                new Employee { Id = 61, FirstName = "Marion", LastName = "Sleeny", Email = "msleeny1o@blogger.com", Department = "Human Resources", Avatar = "https://robohash.org/perferendisminimasimilique.png?size=100x100&set=set1" },
                new Employee { Id = 62, FirstName = "Banky", LastName = "Rudolph", Email = "brudolph1p@state.gov", Department = "Research and Development", Avatar = "https://robohash.org/debitisvoluptasenim.png?size=100x100&set=set1" },
                new Employee { Id = 63, FirstName = "Bernadine", LastName = "Kennermann", Email = "bkennermann1q@issuu.com", Department = "Research and Development", Avatar = "https://robohash.org/omnisvoluptatumquidem.png?size=100x100&set=set1" },
                new Employee { Id = 64, FirstName = "Kiri", LastName = "Tattershaw", Email = "ktattershaw1r@dagondesign.com", Department = "Product Management", Avatar = "https://robohash.org/quisetcupiditate.png?size=100x100&set=set1" },
                new Employee { Id = 65, FirstName = "Shanta", LastName = "Collaton", Email = "scollaton1s@cbc.ca", Department = "Training", Avatar = "https://robohash.org/rerumaccusantiumea.png?size=100x100&set=set1" },
                new Employee { Id = 66, FirstName = "Conrade", LastName = "Sor", Email = "csor1t@angelfire.com", Department = "Engineering", Avatar = "https://robohash.org/sapientedoloremquidem.png?size=100x100&set=set1" },
                new Employee { Id = 67, FirstName = "Kristo", LastName = "Mankor", Email = "kmankor1u@blinklist.com", Department = "Accounting", Avatar = "https://robohash.org/autevenietpariatur.png?size=100x100&set=set1" },
                new Employee { Id = 68, FirstName = "Janaye", LastName = "Eacott", Email = "jeacott1v@digg.com", Department = "Business Development", Avatar = "https://robohash.org/atquelaborumquidem.png?size=100x100&set=set1" },
                new Employee { Id = 69, FirstName = "Myriam", LastName = "Flecknoe", Email = "mflecknoe1w@csmonitor.com", Department = "Training", Avatar = "https://robohash.org/odioutsed.png?size=100x100&set=set1" },
                new Employee { Id = 70, FirstName = "Griswold", LastName = "Bumphrey", Email = "gbumphrey1x@hp.com", Department = "Legal", Avatar = "https://robohash.org/nihildoloremab.png?size=100x100&set=set1" },
                new Employee { Id = 71, FirstName = "Rebeka", LastName = "Shovel", Email = "rshovel1y@paypal.com", Department = "Research and Development", Avatar = "https://robohash.org/mollitiaipsaeligendi.png?size=100x100&set=set1" },
                new Employee { Id = 72, FirstName = "Saidee", LastName = "Baulk", Email = "sbaulk1z@google.fr", Department = "Product Management", Avatar = "https://robohash.org/remquiacorporis.png?size=100x100&set=set1" },
                new Employee { Id = 73, FirstName = "Colene", LastName = "Bogart", Email = "cbogart20@eventbrite.com", Department = "Research and Development", Avatar = "https://robohash.org/nonanimibeatae.png?size=100x100&set=set1" },
                new Employee { Id = 74, FirstName = "Vera", LastName = "Liff", Email = "vliff21@twitter.com", Department = "Human Resources", Avatar = "https://robohash.org/explicaboquasiinventore.png?size=100x100&set=set1" },
                new Employee { Id = 75, FirstName = "Euphemia", LastName = "Frantzen", Email = "efrantzen22@psu.edu", Department = "Marketing", Avatar = "https://robohash.org/quosdeseruntsimilique.png?size=100x100&set=set1" },
                new Employee { Id = 76, FirstName = "Garrard", LastName = "Feaveryear", Email = "gfeaveryear23@slashdot.org", Department = "Legal", Avatar = "https://robohash.org/velitnamnecessitatibus.png?size=100x100&set=set1" },
                new Employee { Id = 77, FirstName = "Halsey", LastName = "Yoxall", Email = "hyoxall24@instagram.com", Department = "Sales", Avatar = "https://robohash.org/corruptivelitarchitecto.png?size=100x100&set=set1" },
                new Employee { Id = 78, FirstName = "Raphael", LastName = "Acott", Email = "racott25@twitter.com", Department = "Support", Avatar = "https://robohash.org/quisveniamunde.png?size=100x100&set=set1" },
                new Employee { Id = 79, FirstName = "Dina", LastName = "Jessel", Email = "djessel26@gravatar.com", Department = "Research and Development", Avatar = "https://robohash.org/velitestmolestiae.png?size=100x100&set=set1" },
                new Employee { Id = 80, FirstName = "Kerry", LastName = "Scutter", Email = "kscutter27@livejournal.com", Department = "Engineering", Avatar = "https://robohash.org/eterrorfugiat.png?size=100x100&set=set1" },
                new Employee { Id = 81, FirstName = "Gianina", LastName = "Dayce", Email = "gdayce28@cnbc.com", Department = "Training", Avatar = "https://robohash.org/ullametrerum.png?size=100x100&set=set1" },
                new Employee { Id = 82, FirstName = "Claudio", LastName = "Craisford", Email = "ccraisford29@cnn.com", Department = "Accounting", Avatar = "https://robohash.org/doloribuscommodiincidunt.png?size=100x100&set=set1" },
                new Employee { Id = 83, FirstName = "Otis", LastName = "Farren", Email = "ofarren2a@wunderground.com", Department = "Marketing", Avatar = "https://robohash.org/doloresmolestiasest.png?size=100x100&set=set1" },
                new Employee { Id = 84, FirstName = "Gertie", LastName = "Braam", Email = "gbraam2b@shinystat.com", Department = "Engineering", Avatar = "https://robohash.org/evenietaliasvelit.png?size=100x100&set=set1" },
                new Employee { Id = 85, FirstName = "Petr", LastName = "Phette", Email = "pphette2c@ibm.com", Department = "Business Development", Avatar = "https://robohash.org/sedcorruptiad.png?size=100x100&set=set1" },
                new Employee { Id = 86, FirstName = "Willow", LastName = "Thiem", Email = "wthiem2d@prweb.com", Department = "Legal", Avatar = "https://robohash.org/possimusporroconsequatur.png?size=100x100&set=set1" },
                new Employee { Id = 87, FirstName = "Nelie", LastName = "Hynes", Email = "nhynes2e@gizmodo.com", Department = "Engineering", Avatar = "https://robohash.org/animiinrepellat.png?size=100x100&set=set1" },
                new Employee { Id = 88, FirstName = "Jasmine", LastName = "Beri", Email = "jberi2f@wunderground.com", Department = "Services", Avatar = "https://robohash.org/rerumvoluptatemodi.png?size=100x100&set=set1" },
                new Employee { Id = 89, FirstName = "Sibella", LastName = "Bonham", Email = "sbonham2g@cbslocal.com", Department = "Human Resources", Avatar = "https://robohash.org/inciduntesterror.png?size=100x100&set=set1" },
                new Employee { Id = 90, FirstName = "Magda", LastName = "Piola", Email = "mpiola2h@nhs.uk", Department = "Services", Avatar = "https://robohash.org/sedatquos.png?size=100x100&set=set1" },
                new Employee { Id = 91, FirstName = "Shermie", LastName = "Maudlin", Email = "smaudlin2i@cyberchimps.com", Department = "Services", Avatar = "https://robohash.org/autetquisquam.png?size=100x100&set=set1" },
                new Employee { Id = 92, FirstName = "Dulcea", LastName = "Barbary", Email = "dbarbary2j@i2i.jp", Department = "Research and Development", Avatar = "https://robohash.org/consecteturnihilvoluptatem.png?size=100x100&set=set1" },
                new Employee { Id = 93, FirstName = "Keefer", LastName = "Habben", Email = "khabben2k@state.gov", Department = "Business Development", Avatar = "https://robohash.org/maximedoloreut.png?size=100x100&set=set1" },
                new Employee { Id = 94, FirstName = "Dorothy", LastName = "Allanby", Email = "dallanby2l@mediafire.com", Department = "Support", Avatar = "https://robohash.org/minusidet.png?size=100x100&set=set1" },
                new Employee { Id = 95, FirstName = "Tobias", LastName = "Kippax", Email = "tkippax2m@so-net.ne.jp", Department = "Engineering", Avatar = "https://robohash.org/quiavelpossimus.png?size=100x100&set=set1" },
                new Employee { Id = 96, FirstName = "Burty", LastName = "Greenlies", Email = "bgreenlies2n@fotki.com", Department = "Support", Avatar = "https://robohash.org/laudantiumfugacupiditate.png?size=100x100&set=set1" },
                new Employee { Id = 97, FirstName = "Harrison", LastName = "Engall", Email = "hengall2o@google.ru", Department = "Engineering", Avatar = "https://robohash.org/esseitaquemagni.png?size=100x100&set=set1" },
                new Employee { Id = 98, FirstName = "Joaquin", LastName = "Stimson", Email = "jstimson2p@un.org", Department = "Business Development", Avatar = "https://robohash.org/sintmolestiaefacere.png?size=100x100&set=set1" },
                new Employee { Id = 99, FirstName = "Retha", LastName = "Petyanin", Email = "rpetyanin2q@shareasale.com", Department = "Training", Avatar = "https://robohash.org/explicaboautest.png?size=100x100&set=set1" },
                new Employee { Id = 100, FirstName = "Kerstin", LastName = "Wakely", Email = "kwakely2r@google.de", Department = "Engineering", Avatar = "https://robohash.org/saepeconsecteturdoloremque.png?size=100x100&set=set1" }
                );
        }
    }
}
