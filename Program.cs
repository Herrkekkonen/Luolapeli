using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            Aloitus:
            Console.ReadKey();
            Console.WriteLine("6.4.1985. Lento Braziliasta Ohioon. klo:14.22");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Olet paluumatkalla työmatkaltasi. Mietit lastasi ja puristat kädessäsi hänelle ostamaasi Rambo-Figuuria.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Mielessäsi välähtää vaimosi, kuinka hän leikkii lapsenne kanssa. `Kolme kuukautta työmatkalla`- Mietit ja naureskelet itsellesi, `Mukava päästä kotiin taas`- ja kaivat laukustasi oluen siitä sixpäkistä, jonka salakuljetit lentokoneeseen. ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Katselet kauniita maisemia lentokoneesta ja huokailet, olisipa vaimosi mukana näkemässä nämä");
            Console.ReadKey();
            Console.Clear();

            Console.ReadKey();                                              //TODO JATKA
            goto aloitus2;

            aloitus2:
            Console.Clear();
            Console.WriteLine("Pian ajattelusi keskeyttää jäätävä rymähdys.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Näet kuinka sinun puolen siipi irtoaa lentokoneesta ja häviää koneen taakse.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ihmisten meluaminen ja panikointi pysähtyy hetkeksi kun kapteeni kuuluttaa");
            Console.WriteLine("'Täällä koneen kapteeni, toinen siipemme on irronnut. Siirrymme Pakkolaskuun. Pysykää rauhallisina ja istukaa paikoillaan.'");
            Console.ReadKey();
            Console.WriteLine("Jonka jälkeen ihmiset alkavat panikoida ja juoksennella ympäri lentokonetta etsien ulospääsyä");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Elämäsi vilisee silmiesi edessä, Lomamatkat vaimosi kanssa, Lapsen ristiäiset, häät, ensimmäiset kännit...");
            Console.ReadKey();
            Console.WriteLine("Ensimmäinen...");
            Console.ReadKey();
            Console.WriteLine("Niin...");
            Console.ReadKey();
            Console.WriteLine("Puristat kädessäsi Pojallesi ostamaasi Rambo-Figuuria.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Kone alkaa täristä, Kapteeni kuuluttaa 'Nyt voi tuntua hieman turbulenssia'. ihmiset panikoivat...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Kone rämähtää maahan, korvissasi piippaa ja näet vain pimeää");
            Console.ReadKey();
            goto Aloitus3;

            Aloitus3:
            Console.Clear();
            Console.WriteLine("Heräät Autiolta saarelta sammuneen nuotion vierestä, sinulla on kylmä");
            Console.ReadKey();
            Console.WriteLine("Tarkemman tarkastelun jälkeen huomaat, ettei vieressäsi olekaan nuotio, vaan loppuunpalanut lentokoneen raato.");
            Console.ReadKey();
            Console.WriteLine("Joka puolella on kuolleita. Näet matkalaukkusi raadon keskellä, joten päätät naapata sen mukaan");
            Console.ReadKey();
            goto kysymys1;


            //INTRO LOPPUU
            //PELI ALKAA
            kysymys1:
            Console.Clear();
            Console.WriteLine("Näet Oikealla luolan, \nMene sisään?\n1 Mene\n2 Älä mene");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Luolassa on pimeää, kuulet rottien ääniä, näet luurankoja ja haistat kuolleen. ");
                    Console.ReadKey();
                    goto Kysymys2;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Käännyt ympäri, katselet hetkenaikaa koneenraatoasi. Avaat oluen, juotuasi sen katselet ympärillesi.");
                    Console.ReadKey();
                    goto enmene;
                    break;









            }
            Kysymys2:
            Console.Clear();
            Console.WriteLine("Kävelet syvemmälle luolaan ja näet luurangon, jonka kädessä on ruosteinen miekka \n Mitä teet?\n1.Ota Miekka\n2.Etsi Toista asetta");
            int b = Convert.ToInt32(Console.ReadLine());


            switch (b)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Otat miekan ja jatkat matkaa. Ilma alkaa tuntua tunkkaisemmalta.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Valo alkaa vähentyä, kaivat esiin tulitikut ja raapaiset tikun askin reunaan. Nyt näet taas hetkellisesti.");
                    Console.ReadKey();
                    goto Kysymys3;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Jatkat ilman asetta, Mitään ei tunnu löytyvän. Lisää luurankoja.Kuollut Piisami. Ideasi alkavat loppua, kunnes... ");
                    Console.ReadKey();
                    goto Kysymys4;
                    break;


            }

            Kysymys3:
            Console.Clear();
            Console.WriteLine("Sytyttäessäsi uuden tulitikun, valon takaa paljastuu vihainen valtava tiikeri.\nMitä Teet?\n1.Tapa Tiikeri kuoliaaksi\n2.Juokse!\n3.Yritä silittää tiikeriä");
            int c = Convert.ToInt32(Console.ReadLine());


            switch (c)
            {



                case 1:
                    Console.Clear();
                    Console.WriteLine("Silpaiset Tiikeriä Miekalla, Tiikeri lyö takaisin, haavaasi sattuu. Lyöt lujempaa ja tiikeri kaatuu maahan. Voitit! Jatkat matkaa ja näet luurangon jolla on kädessä jotain, tiputat miekkasi sillä...");
                    Console.ReadKey();
                    goto Kysymys4;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Juokset karkuun. Tiikeri kuitenkin saa sinut kiinni ja syö sinut...");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Yrität laittaa kätesi tiikerin selälle, tiikeri ei kuitenkaan ole kesytettävää sorttia, ja syö sinut...");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;

            }

            Kysymys4:
            Console.Clear();
            Console.WriteLine("...löydät Taistelukirveen! Otat kirveen ja jatkat matkaa. Pitkän matkan jälkeen, kun sytytät tulitikun nähdäksesi, huomaat että Luola haarautuu kolmeen.\nMinne menet?\n1.Vasen\n2.Suoraan\n3.Oikealle\n4.Palaa.");
            int d = Convert.ToInt32(Console.ReadLine());


            switch (d)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("UMPIKUJA!, Palaat takaisin pettyneenä");
                    Console.ReadKey();
                    goto Takaisin1;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("UMPIKUJA!, Palaat takaisin pettyneenä");
                    Console.ReadKey();
                    goto Takaisin2;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Lähdet oikealle. Luola näyttää jatkuvan todella pitkään. Otat päättäväisen henkäyksen ja lähdet kävelemään.");
                    goto kysymys1;
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Päätät kääntyä takaisin, Matka tulee olemaan pitkä joten pistät juoksuksi. Tunnelin päässä näkyy valoa.");
                    Console.ReadKey();
                    Console.WriteLine("Valo osoittautuu Tunnelin uloskäynniksi. Päädyt sinne mistä lähditkin.");
                    Console.ReadKey();
                    goto kysymys6;
                    break;

            }

            Takaisin1:
            Console.Clear();
            Console.WriteLine("Palaat aikaisempaan haarautumaan\nMinne suuntaan seuraavaksi?\n1.Oikealle\n2.Vasempaan\n3.Suoraan\n4.Palaa.");
            int e = Convert.ToInt32(Console.ReadLine());

            switch (e)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Lähdet oikealle. Pitkän matkan jälkeen näet valoa tunnelin päässä.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Päädyt sinne mistä lähditkin, tunnelin ulkopuolelle.");
                    Console.ReadKey();
                    goto kysymys6;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Lähdet Vasempaan. Päädyt umpikujaan. Palaat takaisin pettyneenä.");
                    Console.ReadKey();
                    goto Valinnainenloppu;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Lähdet suoraan. Luola näyttää jatkuvan pitkälle joten päätät pistää juoksuksi.");
                    Console.ReadKey();
                    goto kysymys1;
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Palaat takaisin.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("PERKELE! Edelleen umpikuja...");
                    Console.ReadKey();
                    goto Valinnat1;

                    break;

            }

            Takaisin2: Console.Clear();
            Console.WriteLine("Päädyt takaisin aikaisempaan haarautumaan\nMinne suuntaan tälläkertaa?\n1.Oikealle\n2.Suoraan\n3.Vasempaan\n4.Palaa takaisin.");
            int f = Convert.ToInt32(Console.ReadLine());

            switch (f)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Lähdet Oikeaan.");
                    Console.ReadKey();
                    Console.WriteLine("Päädyt umpikujaan. Palaat takaisin.");
                    goto Takaisin1;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Lähdet suoraan eteenpäin. Näet tunnelin päässä valoa.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Päädyt sinne mistä lähditkin, tunnelin ulkopuolelle.");
                    Console.ReadKey();
                    goto Valinnainenloppu;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Päätät lompsia vasempaan. Tunneli tuntuu pitkältä, joten pistät juoksuksi.");
                    Console.ReadKey();
                    goto Valinnainenloppu;
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Palaat takaisin.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("SAATANA! Edelleen umpikuja. palaat takaisin erittäin pettyneenä.");
                    Console.ReadKey();
                    goto Takaisin2;
                    break;

            }

            Kuollut1: Console.Clear();
            Console.WriteLine("Elämäsi vilisee silmiesi edessä...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Näet vaimosi ja lapsesi naureskelemassa, heillä on kivaa");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Yrität huutaa heille, mutta et saa ääntä ulos.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vähitellen muistot alkavat himmetä...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Pian näet vain pimeää...");
            Console.ReadKey();
            Console.Clear();
            Console.ReadKey();
            Console.WriteLine("Olosi on painoton ja voimaton. Kuulet veden tippasevan jossain kaukana.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Pian sekin alkaa hiljentyä. Et kuule enää mitään...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Olet kuollut...");
            Console.ReadKey();
            Console.Clear();
            Console.ReadKey();
            Console.WriteLine("Ympärilläsi on vain pimeää. \nHaluatko yrittää uudelleen?\n1.Kyllä\n2.Ei");
            int g = Convert.ToInt32(Console.ReadLine());

            switch (g)
            {
                case 1:
                    Console.Clear();
                    Console.ReadKey();
                    goto kysymys1;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Paina mitä tahansa poistuaksesi");
                    Console.ReadKey();
                    goto lopetapeli;
                    break;
            }

            Valinnat1: Console.Clear();

            Console.WriteLine("Huomaat nurkassa pienen halkeaman.\nAlat avartamaan halkeamaa...\n1....Käsilläsi\n2....Kirveelläsi");
            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Alat kaivamaan käsilläsi halkeamaa.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Pitkän ajan jälkeen käsiisi alkaa sattumaan, mutta halkeama on jo avartunut aika paljon...");
                    Console.ReadKey();
                    goto kysymys5;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Nostat kirveesi korkealle ilmaan, ja pamautat sillä lujaa kiveen. Halkeama suurenee hieman joten jatkat hakkaamista...");
                    Console.ReadKey();
                    goto Valinnainenloppu;
                    break;


            }

            enmene:
            Console.Clear();
            Console.WriteLine("\nMinne suuntaan lähdet?\n1.Oikeaan\n2.Vasempaan\n3.Lähde uimaan");
            int j = Convert.ToInt32(Console.ReadLine());

            switch (j)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Päätät lähteä oikeaan.");
                    Console.ReadKey();
                    Console.WriteLine("Palmujen takaa paljastuu alkuasukasheimo. He ottavat sinut ilomielin vastaan.");
                    Console.ReadKey();
                    Console.WriteLine("Vietät hauskaa aikaa. Muutaman päivän päästä lentokone noutaa sinut kotiin.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Hyvästelet heimon, ja nouset lentokoneeseen. Hukkasit Rambo-Figuurisi, mutta pääset vihdoin perheesi luokse.");
                    Console.ReadKey();
                    Console.WriteLine("Pääset kotiin, halaat vaimoasi ja lastasi, Kerrot heille tarinoita alkuasukkaista.");
                    Console.ReadKey();
                    goto Selvisin;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Pitkän vaelluksen jälkeen päätät napata marjoja ruuaksi.");
                    Console.ReadKey();
                    Console.WriteLine("Sinulle tulee hassu olo, alat nähdä näkyjä.");
                    Console.ReadKey();
                    Console.WriteLine("Luulet edessäsi seisovaa tiikeriä näyksi, menet rapsuttelemaan sitä. Tiikerihän ei siitä pidä ja syö sinut...");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Lähdet uimaan pois saarelta, Pian uiminen alkaa tuntua raskaammalta ja alat upota. Osut pohjaan ja viimeinenkin Happimolekyyli valuu ulos keuhkoistasi");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;
            }

            kysymys5:
            Console.Clear();
            Console.WriteLine("Jatkat hakkaamista, menetät paljon verta. Saat halkeaman auki, avaat oluen laukustasi ja jatkat matkaa.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Löydät pitkän matkan jälkeen pienen huoneen näköisen tilan. Tutkit hieman ja löydät huoneen omistajan, mädäntynyt luuranko sängyllä.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Teet ruokaa huoneen keskellä olevalla nuotiolla, juttelet asukkaalle, juot olutta, nukut asukkaan vieressä. Heräät kun susi nuolee naamaasi");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Koira on syönyt loput ruokasi, ja täten se on kesyyntynyt. Taputat sutta päälaelle, annat sille nimeksi Hurtta.");
            Console.ReadKey();
            Console.WriteLine("Jatkat matkaa, muutaman mutkan jälkeen saavut leijonan luolaan.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hyppäät nurkan taakse, \nmitä teet\n1.Käske hurtta hyökkäämään.\n2.Hyökkää itse hurtan kanssa.\n3.Hiiviskele ohitse");
            int k = Convert.ToInt32(Console.ReadLine());

            switch (k)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Hurtta lähtee tiikerien keskelle, noin 0.2243 sekuntia myöhemmin Hurtta makaa kuolleena maassa ja tiikerit hyökkäävät sinun päällesi.");
                    Console.ReadKey();
                    Console.WriteLine("tapat muutaman, mutta tiikerit eivät lopu kesken. Tiikerit raatelevat sinut");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Hyökkäät huutaen tiikerien keskelle, Hurtta juoksee vierelläsi");
                    Console.ReadKey();
                    Console.WriteLine("Tapat muutaman tiikerin, Hurtta tappaa myös pari, Mutta tiikerit eivät luovuta ja jyräävät sinut ja Hurtan.");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Lähdet hiiviskelemään");
                    Console.ReadKey();
                    goto Hiiviskely;
                    break;
            }


            Hiiviskely:
            {
                char hurtta;
                char rupsu;
                Console.Clear();
                Console.WriteLine("Kuiskaa hurtta mukaasi y/n");
                hurtta = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Hiiviskellessäsi sinulla tulee kauhea tarve pieraista, päästätkö kaasuja? y/n");
                rupsu = Convert.ToChar(Console.ReadLine());

                if (hurtta == 'y' && rupsu == 'y')
                {
                    Console.WriteLine("Kuiskaat hurtan mukaasi, hiiviskellessäsi päästät pierun, joka osoittautuu erittäin äänekkääksi.");
                    Console.ReadKey();
                    Console.WriteLine("Kaikki tiikerit huomaavat sinut ja hurtan. Teistä ei ole vastukseksi.");
                    Console.ReadKey();
                    goto Kuollut1;

                }

                if (hurtta == 'y' && rupsu == 'n')
                {
                    Console.WriteLine("Kuiskaat hurtan mukaasi, hiiviskellessäsi sinulla tulee tarve pieraista, mutta pidät kaasut sisälläsi");
                    Console.ReadKey();
                    Console.WriteLine("Pääset ohitse, nurkan taakse kääntyessäsi hengähdät, ja pieru tulee pihalle erittäin äänekkäästi. Lähdette hurtan kanssa juoksemaan.");
                    Console.ReadKey();
                    goto Valinnainenloppu;
                }
                if (hurtta == 'n' && rupsu == 'y')
                {
                    Console.WriteLine("Hurtta jää odottelemaan, hiiviskellessäsi päästät pierun, joka osoittautuu erittäin äänekkääksi.");
                    Console.ReadKey();
                    Console.WriteLine("Kaikki tiikerit huomaavat sinut. Sinusta ei ole vastukseksi.");
                    Console.ReadKey();
                    goto Kuollut1;

                }
                if (hurtta == 'n' && rupsu == 'n')
                {
                    Console.WriteLine("Hurtta jää odottelemaan, hiiviskellessäsi sinulla tulee tarve pieraista, mutta pidät kaasut sisälläsi");
                    Console.ReadKey();
                    Console.WriteLine("Pääset ohitse, nurkan taakse kääntyessäsi hengähdät ja viitot hurtan tulemaan luoksesi. pieru tulee pihalle erittäin äänekkäästi. Lähdette hurtan kanssa juoksemaan.");
                    Console.ReadKey();
                    goto Valinnainenloppu;

                }
                else
                {
                    Console.WriteLine("y= Kyllä");
                    Console.WriteLine("n= Ei");
                    Console.ReadKey();
                    goto Hiiviskely;
                }


            }

            kysymys6:
            Console.Clear();
            Console.WriteLine("Päädyt Luolan ulkopuolelle, \nMinne lähdet?\n1.Vasempaan\n2.Oikeaan\n3.Lähde uimaan");
            int l = Convert.ToInt32(Console.ReadLine());

            switch (l)
            {


                case 1:
                    Console.Clear();
                    Console.WriteLine("Pitkän vaelluksen jälkeen päätät napata marjoja ruuaksi.");
                    Console.ReadKey();
                    Console.WriteLine("Sinulle tulee hassu olo, alat nähdä näkyjä.");
                    Console.ReadKey();
                    Console.WriteLine("Luulet edessäsi seisovaa tiikeriä näyksi, menet rapsuttelemaan sitä. Tiikerihän ei siitä pidä ja syö sinut...");
                    Console.ReadKey();
                    goto Kuollut1;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Päätät lähteä oikeaan.");
                    Console.ReadKey();
                    Console.WriteLine("Palmujen takaa paljastuu alkuasukasheimo. He ottavat sinut ilomielin vastaan.");
                    Console.ReadKey();
                    Console.WriteLine("Vietät hauskaa aikaa. Muutaman päivän päästä lentokone noutaa sinut kotiin.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Hyvästelet heimon, ja nouset lentokoneeseen. Hukkasit Rambo-Figuurisi, mutta pääset vihdoin perheesi luokse.");
                    Console.ReadKey();
                    Console.WriteLine("Pääset kotiin, halaat vaimoasi ja lastasi, Kerrot heille tarinoita alkuasukkaista.");
                    Console.ReadKey();
                    goto Selvisin;
                    break;

            }
            Selvisin:
            { 

            
            Console.Clear();
            Console.WriteLine("Selvisit kotiin!, Onneksi olkoon!");
            Console.ReadKey();
            Console.WriteLine("                      Kiitokset:");
            Console.WriteLine(" Osao Kaukovainio Palvelut Datanomien Koodausopettajat");
            Console.WriteLine("                  Mikko, Eero ja Juha");
            Console.WriteLine("                       Redbull");
            Console.WriteLine("                  Kltp16a ja Kptop16");
            Console.WriteLine("Tomi Takala 2016-2018");
            Console.ReadKey();
            Console.WriteLine("Paina mitä tahansa nappia poistuaksesi");
            Console.ReadKey();
            
        }




            Valinnainenloppu:
            Console.Clear();
            Console.ReadKey();
            goto kysymys1;


            lopetapeli:
            Console.Clear();



        }
    }
}

    
