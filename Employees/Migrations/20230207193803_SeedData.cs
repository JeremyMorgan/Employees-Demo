using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employees.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Avatar", "Department", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "https://robohash.org/autautea.png?size=100x100&set=set1", "Research and Development", "nmorgue0@disqus.com", "Nonie", "Morgue" },
                    { 2, "https://robohash.org/saepeadipiscifugit.png?size=100x100&set=set1", "Research and Development", "klowe1@nymag.com", "Krishna", "Lowe" },
                    { 3, "https://robohash.org/atquerepudiandaecorporis.png?size=100x100&set=set1", "Research and Development", "owilliamson2@washingtonpost.com", "Orville", "Williamson" },
                    { 4, "https://robohash.org/liberotemporibusalias.png?size=100x100&set=set1", "Product Management", "ditzkovici3@phpbb.com", "Dwayne", "Itzkovici" },
                    { 5, "https://robohash.org/enimsapienteillum.png?size=100x100&set=set1", "Research and Development", "sjerisch4@craigslist.org", "Shelbi", "Jerisch" },
                    { 6, "https://robohash.org/omnisillumnostrum.png?size=100x100&set=set1", "Services", "jwitcherley5@1und1.de", "Jerrilee", "Witcherley" },
                    { 7, "https://robohash.org/adipiscisequidolor.png?size=100x100&set=set1", "Marketing", "ckobpac6@goo.ne.jp", "Caritta", "Kobpac" },
                    { 8, "https://robohash.org/aliquamquassunt.png?size=100x100&set=set1", "Human Resources", "qmccague7@facebook.com", "Quincey", "McCague" },
                    { 9, "https://robohash.org/eaquiserror.png?size=100x100&set=set1", "Accounting", "acundey8@yahoo.com", "Aharon", "Cundey" },
                    { 10, "https://robohash.org/dolorconsecteturdeleniti.png?size=100x100&set=set1", "Services", "nanthill9@posterous.com", "Neila", "Anthill" },
                    { 11, "https://robohash.org/veroculpadolore.png?size=100x100&set=set1", "Business Development", "cbroadera@theglobeandmail.com", "Cinnamon", "Broader" },
                    { 12, "https://robohash.org/autveritatisquibusdam.png?size=100x100&set=set1", "Business Development", "gtampinb@example.com", "Godfrey", "Tampin" },
                    { 13, "https://robohash.org/utvoluptasdolorum.png?size=100x100&set=set1", "Support", "oandrellic@t-online.de", "Olimpia", "Andrelli" },
                    { 14, "https://robohash.org/odioinqui.png?size=100x100&set=set1", "Human Resources", "gebblesd@fema.gov", "Grissel", "Ebbles" },
                    { 15, "https://robohash.org/saepedelenitivoluptas.png?size=100x100&set=set1", "Sales", "bsutherleye@bing.com", "Beckie", "Sutherley" },
                    { 16, "https://robohash.org/aspernaturautdicta.png?size=100x100&set=set1", "Sales", "dschohierf@dion.ne.jp", "Drusie", "Schohier" },
                    { 17, "https://robohash.org/dolornobisratione.png?size=100x100&set=set1", "Sales", "aheisterg@soup.io", "Aida", "Heister" },
                    { 18, "https://robohash.org/estnihilsuscipit.png?size=100x100&set=set1", "Services", "vleakeh@umn.edu", "Valentia", "Leake" },
                    { 19, "https://robohash.org/abperspiciatismagnam.png?size=100x100&set=set1", "Training", "ogellatelyi@spotify.com", "Octavius", "Gellately" },
                    { 20, "https://robohash.org/blanditiisvoluptasrerum.png?size=100x100&set=set1", "Product Management", "emandyj@webs.com", "Erwin", "Mandy" },
                    { 21, "https://robohash.org/auteavel.png?size=100x100&set=set1", "Engineering", "adevenportk@google.fr", "Armand", "Devenport" },
                    { 22, "https://robohash.org/consequuntureveniethic.png?size=100x100&set=set1", "Research and Development", "btorell@mit.edu", "Bartel", "Torel" },
                    { 23, "https://robohash.org/fugitmagnamhic.png?size=100x100&set=set1", "Research and Development", "aludgatem@ning.com", "Auberta", "Ludgate" },
                    { 24, "https://robohash.org/voluptatumetet.png?size=100x100&set=set1", "Support", "csendalln@bizjournals.com", "Claudian", "Sendall" },
                    { 25, "https://robohash.org/cupiditateestsoluta.png?size=100x100&set=set1", "Engineering", "sdarrello@auda.org.au", "Saw", "Darrell" },
                    { 26, "https://robohash.org/quosconsequaturqui.png?size=100x100&set=set1", "Research and Development", "anarracottp@dedecms.com", "Arv", "Narracott" },
                    { 27, "https://robohash.org/temporibusperspiciatiscommodi.png?size=100x100&set=set1", "Sales", "scloustonq@ow.ly", "Silvia", "Clouston" },
                    { 28, "https://robohash.org/eoseosdoloremque.png?size=100x100&set=set1", "Support", "fartistr@fda.gov", "Fabio", "Artist" },
                    { 29, "https://robohash.org/nihiloptiout.png?size=100x100&set=set1", "Sales", "elents@wikimedia.org", "Eldredge", "Lent" },
                    { 30, "https://robohash.org/solutaarchitectovoluptate.png?size=100x100&set=set1", "Business Development", "agoodlettt@yellowbook.com", "Arlin", "Goodlett" },
                    { 31, "https://robohash.org/teneturquidemexercitationem.png?size=100x100&set=set1", "Legal", "fkeyseu@mac.com", "Fenelia", "Keyse" },
                    { 32, "https://robohash.org/eligenditotamdelectus.png?size=100x100&set=set1", "Training", "mshawlv@is.gd", "Merilyn", "Shawl" },
                    { 33, "https://robohash.org/dolorevoluptatibusaut.png?size=100x100&set=set1", "Accounting", "mwadelinw@bravesites.com", "Maryellen", "Wadelin" },
                    { 34, "https://robohash.org/delenitiomnisperferendis.png?size=100x100&set=set1", "Sales", "bvanyukovx@vinaora.com", "Blondie", "Vanyukov" },
                    { 35, "https://robohash.org/nostrumharumeveniet.png?size=100x100&set=set1", "Engineering", "lliccardoy@unicef.org", "Leon", "Liccardo" },
                    { 36, "https://robohash.org/corporisquibusdamnisi.png?size=100x100&set=set1", "Engineering", "tburneyz@mac.com", "Theodosia", "Burney" },
                    { 37, "https://robohash.org/laudantiumillorepellendus.png?size=100x100&set=set1", "Accounting", "tbenedyktowicz10@indiatimes.com", "Tiffany", "Benedyktowicz" },
                    { 38, "https://robohash.org/similiquerepellatitaque.png?size=100x100&set=set1", "Business Development", "swathey11@fc2.com", "Salomon", "Wathey" },
                    { 39, "https://robohash.org/utmaximeet.png?size=100x100&set=set1", "Sales", "fmeineking12@cbsnews.com", "Fidelio", "Meineking" },
                    { 40, "https://robohash.org/doloresomnisaut.png?size=100x100&set=set1", "Support", "fdemicoli13@earthlink.net", "Ford", "De Micoli" },
                    { 41, "https://robohash.org/nostrumdoloremqueillum.png?size=100x100&set=set1", "Accounting", "bstebbings14@bbc.co.uk", "Bridie", "Stebbings" },
                    { 42, "https://robohash.org/porroenimdolorem.png?size=100x100&set=set1", "Business Development", "tkarpets15@cmu.edu", "Theressa", "Karpets" },
                    { 43, "https://robohash.org/earumquiaest.png?size=100x100&set=set1", "Services", "tleivesley16@prlog.org", "Twyla", "Leivesley" },
                    { 44, "https://robohash.org/voluptatevoluptatemexcepturi.png?size=100x100&set=set1", "Product Management", "acroney17@purevolume.com", "Alane", "Croney" },
                    { 45, "https://robohash.org/possimusvoluptatesquas.png?size=100x100&set=set1", "Sales", "aurrey18@seesaa.net", "Althea", "Urrey" },
                    { 46, "https://robohash.org/magnamaliasveritatis.png?size=100x100&set=set1", "Business Development", "dphifer19@yale.edu", "Desiri", "Phifer" },
                    { 47, "https://robohash.org/idquaesint.png?size=100x100&set=set1", "Services", "cmeecher1a@walmart.com", "Cicily", "Meecher" },
                    { 48, "https://robohash.org/magnipariaturdolor.png?size=100x100&set=set1", "Business Development", "hupstone1b@bloglines.com", "Harriott", "Upstone" },
                    { 49, "https://robohash.org/quaevelitoccaecati.png?size=100x100&set=set1", "Marketing", "cesler1c@reddit.com", "Cloe", "Esler" },
                    { 50, "https://robohash.org/cumqueipsamiste.png?size=100x100&set=set1", "Training", "mforsdike1d@skyrock.com", "Matelda", "Forsdike" },
                    { 51, "https://robohash.org/similiqueatqueeos.png?size=100x100&set=set1", "Services", "dtrigwell1e@canalblog.com", "Deirdre", "Trigwell" },
                    { 52, "https://robohash.org/impeditnesciuntomnis.png?size=100x100&set=set1", "Legal", "edemendoza1f@latimes.com", "Edgar", "de Mendoza" },
                    { 53, "https://robohash.org/quodeaunde.png?size=100x100&set=set1", "Legal", "nmcnicol1g@i2i.jp", "Neely", "McNicol" },
                    { 54, "https://robohash.org/cumcorruptimollitia.png?size=100x100&set=set1", "Human Resources", "hfinding1h@dell.com", "Henrik", "Finding" },
                    { 55, "https://robohash.org/voluptatumoptiominima.png?size=100x100&set=set1", "Human Resources", "nbrodest1i@surveymonkey.com", "Nevil", "Brodest" },
                    { 56, "https://robohash.org/delectusnumquamnihil.png?size=100x100&set=set1", "Business Development", "bmurr1j@salon.com", "Bartholemy", "Murr" },
                    { 57, "https://robohash.org/aliaseteaque.png?size=100x100&set=set1", "Product Management", "kscragg1k@gov.uk", "Kalil", "Scragg" },
                    { 58, "https://robohash.org/iustoundeperspiciatis.png?size=100x100&set=set1", "Product Management", "acavalier1l@europa.eu", "Abigail", "Cavalier" },
                    { 59, "https://robohash.org/inipsumnihil.png?size=100x100&set=set1", "Accounting", "zlambertciorwyn1m@merriam-webster.com", "Zacharie", "Lambert-Ciorwyn" },
                    { 60, "https://robohash.org/omnisprovidentaperiam.png?size=100x100&set=set1", "Training", "wsturges1n@nytimes.com", "Wallis", "Sturges" },
                    { 61, "https://robohash.org/perferendisminimasimilique.png?size=100x100&set=set1", "Human Resources", "msleeny1o@blogger.com", "Marion", "Sleeny" },
                    { 62, "https://robohash.org/debitisvoluptasenim.png?size=100x100&set=set1", "Research and Development", "brudolph1p@state.gov", "Banky", "Rudolph" },
                    { 63, "https://robohash.org/omnisvoluptatumquidem.png?size=100x100&set=set1", "Research and Development", "bkennermann1q@issuu.com", "Bernadine", "Kennermann" },
                    { 64, "https://robohash.org/quisetcupiditate.png?size=100x100&set=set1", "Product Management", "ktattershaw1r@dagondesign.com", "Kiri", "Tattershaw" },
                    { 65, "https://robohash.org/rerumaccusantiumea.png?size=100x100&set=set1", "Training", "scollaton1s@cbc.ca", "Shanta", "Collaton" },
                    { 66, "https://robohash.org/sapientedoloremquidem.png?size=100x100&set=set1", "Engineering", "csor1t@angelfire.com", "Conrade", "Sor" },
                    { 67, "https://robohash.org/autevenietpariatur.png?size=100x100&set=set1", "Accounting", "kmankor1u@blinklist.com", "Kristo", "Mankor" },
                    { 68, "https://robohash.org/atquelaborumquidem.png?size=100x100&set=set1", "Business Development", "jeacott1v@digg.com", "Janaye", "Eacott" },
                    { 69, "https://robohash.org/odioutsed.png?size=100x100&set=set1", "Training", "mflecknoe1w@csmonitor.com", "Myriam", "Flecknoe" },
                    { 70, "https://robohash.org/nihildoloremab.png?size=100x100&set=set1", "Legal", "gbumphrey1x@hp.com", "Griswold", "Bumphrey" },
                    { 71, "https://robohash.org/mollitiaipsaeligendi.png?size=100x100&set=set1", "Research and Development", "rshovel1y@paypal.com", "Rebeka", "Shovel" },
                    { 72, "https://robohash.org/remquiacorporis.png?size=100x100&set=set1", "Product Management", "sbaulk1z@google.fr", "Saidee", "Baulk" },
                    { 73, "https://robohash.org/nonanimibeatae.png?size=100x100&set=set1", "Research and Development", "cbogart20@eventbrite.com", "Colene", "Bogart" },
                    { 74, "https://robohash.org/explicaboquasiinventore.png?size=100x100&set=set1", "Human Resources", "vliff21@twitter.com", "Vera", "Liff" },
                    { 75, "https://robohash.org/quosdeseruntsimilique.png?size=100x100&set=set1", "Marketing", "efrantzen22@psu.edu", "Euphemia", "Frantzen" },
                    { 76, "https://robohash.org/velitnamnecessitatibus.png?size=100x100&set=set1", "Legal", "gfeaveryear23@slashdot.org", "Garrard", "Feaveryear" },
                    { 77, "https://robohash.org/corruptivelitarchitecto.png?size=100x100&set=set1", "Sales", "hyoxall24@instagram.com", "Halsey", "Yoxall" },
                    { 78, "https://robohash.org/quisveniamunde.png?size=100x100&set=set1", "Support", "racott25@twitter.com", "Raphael", "Acott" },
                    { 79, "https://robohash.org/velitestmolestiae.png?size=100x100&set=set1", "Research and Development", "djessel26@gravatar.com", "Dina", "Jessel" },
                    { 80, "https://robohash.org/eterrorfugiat.png?size=100x100&set=set1", "Engineering", "kscutter27@livejournal.com", "Kerry", "Scutter" },
                    { 81, "https://robohash.org/ullametrerum.png?size=100x100&set=set1", "Training", "gdayce28@cnbc.com", "Gianina", "Dayce" },
                    { 82, "https://robohash.org/doloribuscommodiincidunt.png?size=100x100&set=set1", "Accounting", "ccraisford29@cnn.com", "Claudio", "Craisford" },
                    { 83, "https://robohash.org/doloresmolestiasest.png?size=100x100&set=set1", "Marketing", "ofarren2a@wunderground.com", "Otis", "Farren" },
                    { 84, "https://robohash.org/evenietaliasvelit.png?size=100x100&set=set1", "Engineering", "gbraam2b@shinystat.com", "Gertie", "Braam" },
                    { 85, "https://robohash.org/sedcorruptiad.png?size=100x100&set=set1", "Business Development", "pphette2c@ibm.com", "Petr", "Phette" },
                    { 86, "https://robohash.org/possimusporroconsequatur.png?size=100x100&set=set1", "Legal", "wthiem2d@prweb.com", "Willow", "Thiem" },
                    { 87, "https://robohash.org/animiinrepellat.png?size=100x100&set=set1", "Engineering", "nhynes2e@gizmodo.com", "Nelie", "Hynes" },
                    { 88, "https://robohash.org/rerumvoluptatemodi.png?size=100x100&set=set1", "Services", "jberi2f@wunderground.com", "Jasmine", "Beri" },
                    { 89, "https://robohash.org/inciduntesterror.png?size=100x100&set=set1", "Human Resources", "sbonham2g@cbslocal.com", "Sibella", "Bonham" },
                    { 90, "https://robohash.org/sedatquos.png?size=100x100&set=set1", "Services", "mpiola2h@nhs.uk", "Magda", "Piola" },
                    { 91, "https://robohash.org/autetquisquam.png?size=100x100&set=set1", "Services", "smaudlin2i@cyberchimps.com", "Shermie", "Maudlin" },
                    { 92, "https://robohash.org/consecteturnihilvoluptatem.png?size=100x100&set=set1", "Research and Development", "dbarbary2j@i2i.jp", "Dulcea", "Barbary" },
                    { 93, "https://robohash.org/maximedoloreut.png?size=100x100&set=set1", "Business Development", "khabben2k@state.gov", "Keefer", "Habben" },
                    { 94, "https://robohash.org/minusidet.png?size=100x100&set=set1", "Support", "dallanby2l@mediafire.com", "Dorothy", "Allanby" },
                    { 95, "https://robohash.org/quiavelpossimus.png?size=100x100&set=set1", "Engineering", "tkippax2m@so-net.ne.jp", "Tobias", "Kippax" },
                    { 96, "https://robohash.org/laudantiumfugacupiditate.png?size=100x100&set=set1", "Support", "bgreenlies2n@fotki.com", "Burty", "Greenlies" },
                    { 97, "https://robohash.org/esseitaquemagni.png?size=100x100&set=set1", "Engineering", "hengall2o@google.ru", "Harrison", "Engall" },
                    { 98, "https://robohash.org/sintmolestiaefacere.png?size=100x100&set=set1", "Business Development", "jstimson2p@un.org", "Joaquin", "Stimson" },
                    { 99, "https://robohash.org/explicaboautest.png?size=100x100&set=set1", "Training", "rpetyanin2q@shareasale.com", "Retha", "Petyanin" },
                    { 100, "https://robohash.org/saepeconsecteturdoloremque.png?size=100x100&set=set1", "Engineering", "kwakely2r@google.de", "Kerstin", "Wakely" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
