using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;

namespace SikhUnit.DataAccess.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DatabaseContext context)
        {
            InsertLiteratures(context);
            InsertAlbums(context);
            InsertSongs(context);
            InsertOtherSites(context);
        }

        private void InsertOtherSites(DatabaseContext context)
        {
            context.OtherSites.AddOrUpdate(s => s.DisplayName, new OtherSite { DisplayName = "Sikh Unit YouTube Site", Url = "https://www.youtube.com/channel/UCP3IcdHmY_rRRdiObLWQebQ" });
            context.OtherSites.AddOrUpdate(s => s.DisplayName, new OtherSite { DisplayName = "Sikh Unit BlogSpot Site", Url = "http://www.officialsikhunit.blogspot.co.uk" });

            context.SaveChanges();
        }

        private void InsertLiteratures(DatabaseContext context)
        {
            context.Literatures.AddOrUpdate(s => s.Name, new Literature { Name = "Sikh Pride Book By Sikh Unit.docx.pdf", DisplayName = "Sikh Pride by Sikh Unit" });

            context.SaveChanges();
        }

        private void InsertSongs(DatabaseContext context)
        {
            // Album 1
            Album one = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 1);

            InsertSong(1, "01 Intro.mp3", one, context);
            InsertSong(2, "02 Sikh Unit Anthem.mp3", one, context);
            InsertSong(3, "03 U Knw How Da Unit Do.mp3", one, context);
            InsertSong(4, "04 Tribute 2 Da Shaheeds.mp3", one, context);
            InsertSong(5, "05 Beef Freestyle.mp3", one, context);
            InsertSong(6, "06 My Life.mp3", one, context);
            InsertSong(7, "07 Papu.mp3", one, context);
            InsertSong(8, "08 Damn Da Racist Scumz.mp3", one, context);
            InsertSong(9, "09 Drugz.mp3", one, context);
            InsertSong(10, "10 Stinky Fake Friendz.mp3", one, context);
            InsertSong(11, "11 Fattsooooo.mp3", one, context);

            // Album 2
            Album two = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 2);

            InsertSong(1, "01 Intro - Rude Awakening.mp3", two, context);
            InsertSong(2, "02 We Are Oppressed.mp3", two, context);
            InsertSong(3, "03 Who Do I Trust.mp3", two, context);
            InsertSong(4, "04 Slander.mp3", two, context);
            InsertSong(5, "05 Interlude.mp3", two, context);
            InsertSong(6, "06 Sacrifice of Sri Guru Teg Bahadur Ji.mp3", two, context);
            InsertSong(7, "07 Lying Gill.mp3", two, context);
            InsertSong(8, "08 Warriors Anthem.mp3", two, context);
            InsertSong(9, "09 Young Blud.mp3", two, context);
            InsertSong(10, "10 Charanjit - True Story.mp3", two, context);
            InsertSong(11, "11 Unity.mp3", two, context);
            InsertSong(12, "12 Sikh and Proud.mp3", two, context);
            InsertSong(13, "13 Charanjit Remix.mp3", two, context);
            InsertSong(14, "14 Who Do I Trust Remix.mp3", two, context);
            InsertSong(15, "15 Sukhi and Mukhi.mp3", two, context);

            // Album 3
            Album three = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 3);

            InsertSong(1, "01 Punjabi Bimbo.mp3", three, context);
            InsertSong(2, "02 Im Alcohol.mp3", three, context);
            InsertSong(3, "03 I aint no Meaterian.mp3", three, context);
            InsertSong(4, "04 Im Reppin the 5ks.mp3", three, context);
            InsertSong(5, "05 Heart Like Steel.mp3", three, context);
            InsertSong(6, "06 Bruv I Got Beef.mp3", three, context);
            InsertSong(7, "07 Keepin It Militant.mp3", three, context);
            InsertSong(8, "08 Baba Jarnail Singh Ji Speech.mp3", three, context);
            InsertSong(9, "09 R.I.P 2 DA Real Singhs.mp3", three, context);
            InsertSong(10, "10 Saint Soulja.mp3", three, context);
            InsertSong(11, "11 Sell Outs.mp3", three, context);
            InsertSong(12, "12 True Brothers.mp3", three, context);
            InsertSong(13, "13 Khalistani.mp3", three, context);
            InsertSong(14, "14 I Got a Killa Mentality.mp3", three, context);
            InsertSong(15, "15 RSS Cant Stop Us.mp3", three, context);
            InsertSong(16, "16 Kurbani (Sacrifices).mp3", three, context);
            InsertSong(17, "17 Knifeman Anthem.mp3", three, context);
            InsertSong(18, "18 Traitor (Backstabbers).mp3", three, context);
            InsertSong(19, "19 Fakesters (Mukhi).mp3", three, context);
            InsertSong(20, "20 Im A Weak Sikh.mp3", three, context);
            InsertSong(21, "21 Seva Needed.mp3", three, context);

            // Album 4
            Album four = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 4);

            InsertSong(1, "01 Intro (freestyle).mp3", four, context);
            InsertSong(2, "02 Sukhi Kaur Got Spiked.mp3", four, context);
            InsertSong(3, "03 Real Shit.mp3", four, context);
            InsertSong(4, "04 Dutty Gyal.mp3", four, context);
            InsertSong(5, "05 Islamic Extremist.mp3", four, context);
            InsertSong(6, "06 Get Ur Tool.mp3", four, context);
            InsertSong(7, "07 Meet Mr Rambo.mp3", four, context);
            InsertSong(8, "08 Freedom Fighters.mp3", four, context);
            InsertSong(9, "09 True Homies.mp3", four, context);
            InsertSong(10, "10 Amerjit Singh.mp3", four, context);
            InsertSong(11, "11 Why.mp3", four, context);
            InsertSong(12, "12 Ranjit The Druggie.mp3", four, context);
            InsertSong(13, "13 Homeland.mp3", four, context);
            InsertSong(14, "14 Gym Sessionz.mp3", four, context);

            // Album 5
            Album five = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 5);

            InsertSong(1, "01 My Worst Enemiez.mp3", five, context);
            InsertSong(2, "02 Never Forget 84.mp3", five, context);
            InsertSong(3, "03 Spiritual Warrior.mp3", five, context);
            InsertSong(4, "04 Da Khalsa Army.mp3", five, context);
            InsertSong(5, "05 Lil Brotherz & Sistaz.mp3", five, context);
            InsertSong(6, "06 Enemies Remix.mp3", five, context);
            InsertSong(7, "07 Never Forget 84 Remix.mp3", five, context);
            InsertSong(8, "08 Spiritual Warrior Remix.mp3", five, context);
            InsertSong(9, "09 Da Khalsa Army Remix.mp3", five, context);
            InsertSong(10, "10 Lil Brotherz & Sistaz Remix.mp3", five, context);
            InsertSong(11, "11 Freedom Fighterz Remix.mp3", five, context);
            InsertSong(12, "12 Sukhi Got Spiked Remix.mp3", five, context);
            InsertSong(13, "13 Da God Father Remix.mp3", five, context);

            // Album 6
            Album six = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 6);

            InsertSong(1, "01 Intro.mp3", six, context);
            InsertSong(2, "02 Rip Brothers.mp3", six, context);
            InsertSong(3, "03 Bang Bang.mp3", six, context);
            InsertSong(4, "04 The Caste System.mp3", six, context);
            InsertSong(5, "05 Aggi Freestyle.mp3", six, context);
            InsertSong(6, "06 Baba Jarnail Singh Ji Speech.mp3", six, context);
            InsertSong(7, "07 Clown Community.mp3", six, context);
            InsertSong(8, "08 Im On Singhrow.mp3", six, context);
            InsertSong(9, "09 Killaz Dream Freestyle.mp3", six, context);
            InsertSong(10, "10 Mukhi Solo.mp3", six, context);
            InsertSong(11, "11 Poverty Driven Childern.mp3", six, context);
            InsertSong(12, "12 Jagowale Remix.mp3", six, context);
            InsertSong(13, "13 Kharku Singhz Remix.mp3", six, context);
            InsertSong(14, "14 True Brothers.mp3", six, context);
            InsertSong(15, "15 True Stories.mp3", six, context);
            InsertSong(16, "16 Underground Warriors.mp3", six, context);
            InsertSong(17, "17 Unity.mp3", six, context);
            InsertSong(18, "18 Homeland Remix.mp3", six, context);
            InsertSong(19, "19 Get Ur Tool Remix.mp3", six, context);
            InsertSong(20, "20 Outro.mp3", six, context);

            // Album 7
            Album seven = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 7);

            InsertSong(1, "01 Intro.mp3", seven, context);
            InsertSong(2, "02 Kuljug.mp3", seven, context);
            InsertSong(3, "03 East London Ting.mp3", seven, context);
            InsertSong(4, "04 Respect for Gurbani interlude.mp3", seven, context);
            InsertSong(5, "05 Champoin Freestyle.mp3", seven, context);
            InsertSong(6, "06 Lecture for the Papuus.mp3", seven, context);
            InsertSong(7, "07 Payback.mp3", seven, context);
            InsertSong(8, "08 Real life Music.mp3", seven, context);
            InsertSong(9, "09 Shaheed Bhai Balkar Singh.mp3", seven, context);
            InsertSong(10, "10 Shaheed Bhai Mandar Singh.mp3", seven, context);
            InsertSong(11, "11 Da Ghetto.mp3", seven, context);
            InsertSong(12, "12 Missions Beat.mp3", seven, context);
            InsertSong(13, "13 Disrespect Of Gurbani.mp3", seven, context);
            InsertSong(14, "14 I Am Armed And Dangerous.mp3", seven, context);
            InsertSong(15, "15 We Need Unity.mp3", seven, context);
            InsertSong(16, "16 Interview Wid Killa After Youth Program.mp3", seven, context);
            InsertSong(17, "17 Sukha Singh Talk Remixed.mp3", seven, context);
            InsertSong(18, "18 Killa Explainz The Ardas.mp3", seven, context);
            InsertSong(19, "19 Im A Singh.mp3", seven, context);
            InsertSong(20, "20 Fresh From The HMP.mp3", seven, context);
            InsertSong(21, "21 Freedom.mp3", seven, context);

            // Album 8
            Album eight = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 8);

            InsertSong(1, "01 Intro.mp3", eight, context);
            InsertSong(2, "02 Never Forget Bow 09.mp3", eight, context);
            InsertSong(3, "03 I Feel Your Pain.mp3", eight, context);
            InsertSong(4, "04 Cold World.mp3", eight, context);
            InsertSong(5, "05 Tribute (Killa's Mum).mp3", eight, context);
            InsertSong(6, "06 Who Is Next.mp3", eight, context);
            InsertSong(7, "07 Deepness.mp3", eight, context);
            InsertSong(8, "08 Soul Story.mp3", eight, context);
            InsertSong(9, "09 Are You Ready.mp3", eight, context);
            InsertSong(10, "10 Cold World Remix.mp3", eight, context);
            InsertSong(11, "11 I Feel Your Pain Remix.mp3", eight, context);
            InsertSong(12, "12 Tribute Remix (Killa's Mum).mp3", eight, context);
            InsertSong(13, "13 Alone.mp3", eight, context);
            InsertSong(14, "14 Militant Warrior (Interlude).mp3", eight, context);
            InsertSong(15, "15 25 Years Tune.mp3", eight, context);
            InsertSong(16, "16 25 Years Freestyle.mp3", eight, context);
            InsertSong(17, "17 Messed Up World.mp3", eight, context);
            InsertSong(18, "18 Killa's Wife.mp3", eight, context);
            InsertSong(19, "19 Eyes Of The Kharkoo.mp3", eight, context);
            InsertSong(20, "20 Wastemans.mp3", eight, context);
            InsertSong(21, "21 Roads.mp3", eight, context);
            InsertSong(22, "22 Street Life.mp3", eight, context);
            InsertSong(23, "23 Inner Thoughts.mp3", eight, context);
            InsertSong(24, "24 Forget The Talking.mp3", eight, context);
            InsertSong(25, "25 Talking The Hardest Part 1.mp3", eight, context);
            InsertSong(26, "26 Talking The Hardest Part 2.mp3", eight, context);
            InsertSong(27, "27 Talking The Hardest Part 3.mp3", eight, context);
            InsertSong(28, "28 Outro.mp3", eight, context);

            // Album 9
            Album nine = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 9);

            InsertSong(1, "01 Intro.mp3", nine, context);
            InsertSong(2, "02 Ghetto Ft Akon.mp3", nine, context);
            InsertSong(3, "03 Child Hood Freinds.mp3", nine, context);
            InsertSong(4, "04 Gritty.mp3", nine, context);
            InsertSong(5, "05 Round Ere.mp3", nine, context);
            InsertSong(6, "06 Will There Ever Be Peace.mp3", nine, context);
            InsertSong(7, "07 Cry.mp3", nine, context);
            InsertSong(8, "08 Hood Life.mp3", nine, context);
            InsertSong(9, "09 Deep Down In My Heart.mp3", nine, context);
            InsertSong(10, "10 Journey.mp3", nine, context);
            InsertSong(11, "11 Hold My Hand.mp3", nine, context);
            InsertSong(12, "12 Hold You Down.mp3", nine, context);
            InsertSong(13, "13 Locked Up.mp3", nine, context);
            InsertSong(14, "14 My Wifey.mp3", nine, context);
            InsertSong(15, "15 Once We Were Warriors.mp3", nine, context);
            InsertSong(16, "16 POW.mp3", nine, context);
            InsertSong(17, "17 Pumpy.mp3", nine, context);
            InsertSong(18, "18 They Out To Get Us.mp3", nine, context);
            InsertSong(19, "19 Unity.mp3", nine, context);
            InsertSong(20, "20 Wanna Be Gangsters.mp3", nine, context);
            InsertSong(21, "21 Warm Up.mp3", nine, context);

            // Album 10
            Album ten = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 10);

            InsertSong(1, "01 Intro.mp3", ten, context);
            InsertSong(2, "02 Ride Out.mp3", ten, context);
            InsertSong(3, "03 Singh In Da Hood.mp3", ten, context);
            InsertSong(4, "04 Still On It.mp3", ten, context);
            InsertSong(5, "05 Yung Blud Part 2.mp3", ten, context);
            InsertSong(6, "06 Realness.mp3", ten, context);
            InsertSong(7, "07 Jail Letter.mp3", ten, context);
            InsertSong(8, "08 Snake City.mp3", ten, context);
            InsertSong(9, "09 War Story.mp3", ten, context);
            InsertSong(10, "10 I Need To Getaway.mp3", ten, context);
            InsertSong(11, "11 World Of Hate.mp3", ten, context);
            InsertSong(12, "12 Real Pain.mp3", ten, context);
            InsertSong(13, "13 Feel My Pain.mp3", ten, context);
            InsertSong(14, "14 Verbal Cry.mp3", ten, context);
            InsertSong(15, "15 Luv U Ma.mp3", ten, context);
            InsertSong(16, "16 Waste Girls.mp3", ten, context);
            InsertSong(17, "17 Chill Out On My Own.mp3", ten, context);
            InsertSong(18, "18 Still On It Remix.mp3", ten, context);

            // Album 11
            Album eleven = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 11);

            InsertSong(1, "01 Intro.mp3", eleven, context);
            InsertSong(2, "02 Too My Sistaz.mp3", eleven, context);
            InsertSong(3, "03 Mai Bhag Kaur Tribute.mp3", eleven, context);
            InsertSong(4, "04 My Real Father.mp3", eleven, context);
            InsertSong(5, "05 My Kirpan.mp3", eleven, context);
            InsertSong(6, "06 Don't Forget Your History.mp3", eleven, context);
            InsertSong(7, "07 Luv U Ma Part 2.mp3", eleven, context);
            InsertSong(8, "08 My Message To Waheguru.mp3", eleven, context);
            InsertSong(9, "09 Gun Luv.mp3", eleven, context);
            InsertSong(10, "10 Deciever.mp3", eleven, context);
            InsertSong(11, "11 I See Peepz.mp3", eleven, context);
            InsertSong(12, "12 Fuck Bollywood.mp3", eleven, context);
            InsertSong(13, "13 Come For Me.mp3", eleven, context);
            InsertSong(14, "14 Hood Shit.mp3", eleven, context);
            InsertSong(15, "15 I Did You Wrong.mp3", eleven, context);
            InsertSong(16, "16 Ambition Freestyle.mp3", eleven, context);
            InsertSong(17, "17 History Lesson.mp3", eleven, context);
            InsertSong(18, "18 Mind Games.mp3", eleven, context);
            InsertSong(19, "19 Wasted Time.mp3", eleven, context);
            InsertSong(20, "20 2009 Radio Set.mp3", eleven, context);
            InsertSong(21, "21 1st Interview About Garbage.mp3", eleven, context);
            InsertSong(22, "22 2nd Interview About Garbage.mp3", eleven, context);
            InsertSong(23, "23 Killa Talks About Rap Battles.mp3", eleven, context);
            InsertSong(24, "24 Garbage Diss Tune.mp3", eleven, context);
            InsertSong(25, "25 Is Killa Homophobic.mp3", eleven, context);
            InsertSong(26, "26 Fuck Off.mp3", eleven, context);
            InsertSong(27, "27 Garbage U Fudu.mp3", eleven, context);

            // Album 12
            Album twelve = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 12);

            InsertSong(1, "01 My Broken Wings.mp3", twelve, context);
            InsertSong(2, "02 Burn In Hell Pig.mp3", twelve, context);
            InsertSong(3, "03 My People Will Kill U.mp3", twelve, context);
            InsertSong(4, "04 Deep Down Inside (Freestyle).mp3", twelve, context);
            InsertSong(5, "05 Its Mad Outhere.mp3", twelve, context);
            InsertSong(6, "06 Fuck SOA.mp3", twelve, context);
            InsertSong(7, "07 In My Presence.mp3", twelve, context);
            InsertSong(8, "08 We Really Does Dis.mp3", twelve, context);
            InsertSong(9, "09 Our Endz.mp3", twelve, context);
            InsertSong(10, "10 Im Known In My Hood.mp3", twelve, context);
            InsertSong(11, "11 Grimey Bars.mp3", twelve, context);
            InsertSong(12, "12 Guru Kirpa.mp3", twelve, context);
            InsertSong(13, "13 No Snitching Policy.mp3", twelve, context);
            InsertSong(14, "14 Slumdog Suvivor.mp3", twelve, context);
            InsertSong(15, "15 Where I Live.mp3", twelve, context);
            InsertSong(16, "16 Lengman Chronicles Part 1.mp3", twelve, context);
            InsertSong(17, "17 Emotional Anguish.mp3", twelve, context);
            InsertSong(18, "18 War Stories.mp3", twelve, context);
            InsertSong(19, "19 Da Life Of A Real Singh.mp3", twelve, context);
            InsertSong(20, "20 Hood Tales.mp3", twelve, context);
            InsertSong(21, "21 Pussy O's.mp3", twelve, context);
            InsertSong(22, "22 Move It Up A Level.mp3", twelve, context);
            InsertSong(23, "23 How I Feel.mp3", twelve, context);
            InsertSong(24, "24 Londons One & Only.mp3", twelve, context);
            InsertSong(25, "25 - Internet Geeks Freestyle.mp3", twelve, context);
            InsertSong(26, "26 Singh Star Freestyle.mp3", twelve, context);

            // Album 13
            Album thirteen = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 13);

            InsertSong(1, "01 God Gave Me Style.mp3", thirteen, context);
            InsertSong(2, "02 Got To Make A Change.mp3", thirteen, context);
            InsertSong(3, "03 Tribute To Baba Deep Singh Ji.mp3", thirteen, context);
            InsertSong(4, "04 They Chat Shit About Me.mp3", thirteen, context);
            InsertSong(5, "05 I Got A Cruddy State Of Mind.mp3", thirteen, context);
            InsertSong(6, "06 My Life.mp3", thirteen, context);
            InsertSong(7, "07 Tingz R Not Cool.mp3", thirteen, context);
            InsertSong(8, "08 I Got Some Questions.mp3", thirteen, context);
            InsertSong(9, "09 They hate Me.mp3", thirteen, context);
            InsertSong(10, "10 Pains Of Da Ghetto.mp3", thirteen, context);
            InsertSong(11, "11 Papu Anthem.mp3", thirteen, context);
            InsertSong(12, "12 My Lifes A Mess.mp3", thirteen, context);
            InsertSong(13, "13 Im So Stressed Out.mp3", thirteen, context);
            InsertSong(14, "14 Message 2 Da Yungers.mp3", thirteen, context);
            InsertSong(15, "15 Da Streets Is My Home.mp3", thirteen, context);
            InsertSong(16, "16 I Keep It Gully.mp3", thirteen, context);
            InsertSong(17, "17 Holy Artillery.mp3", thirteen, context);
            InsertSong(18, "18 I Pretend To Be A Gun.mp3", thirteen, context);
            InsertSong(19, "19 My True Love.mp3", thirteen, context);
            InsertSong(20, "20 We Do It For Real Hip Hop.mp3", thirteen, context);
            InsertSong(21, "21 For My True Brothers.mp3", thirteen, context);
            InsertSong(22, "22 These R Serious Times.mp3", thirteen, context);
            InsertSong(23, "23 For My Real Sistaz.mp3", thirteen, context);

            // Album 14
            Album fourteen = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 14);

            InsertSong(1, "01. Intro Ft Shanger.mp3", fourteen, context);
            InsertSong(2, "02. Keep Going.mp3", fourteen, context);
            InsertSong(3, "03. Mad World.mp3", fourteen, context);
            InsertSong(4, "04. Real Hip Hop Sound.mp3", fourteen, context);
            InsertSong(5, "05. Stay Free.mp3", fourteen, context);
            InsertSong(6, "06. Mad World Remix.mp3", fourteen, context);
            InsertSong(7, "07. My Wifey.mp3", fourteen, context);
            InsertSong(8, "08. Tough Times.mp3", fourteen, context);
            InsertSong(9, "09. Letter To Butch Singh.mp3", fourteen, context);
            InsertSong(10, "10. Long Time Ago.mp3", fourteen, context);
            InsertSong(11, "11. Trying To Stay Alive.mp3", fourteen, context);
            InsertSong(12, "12. To My Little Yout.mp3", fourteen, context);
            InsertSong(13, "13. Violence.mp3", fourteen, context);
            InsertSong(14, "14. Long Time Ago Remix.mp3", fourteen, context);
            InsertSong(15, "15. Not The Bless Type.mp3", fourteen, context);
            InsertSong(16, "16. Stay Schemin.mp3", fourteen, context);
            InsertSong(17, "17. Slap A Hoe Campaign.mp3", fourteen, context);
            InsertSong(18, "18. The Slums.mp3", fourteen, context);
            InsertSong(19, "19. War Anthem.mp3", fourteen, context);
            InsertSong(20, "20. Straight Riders.mp3", fourteen, context);
            InsertSong(21, "21. Innocent People.mp3", fourteen, context);
            InsertSong(22, "22. Destiny Sound.mp3", fourteen, context);
            InsertSong(23, "23. Hide & kill Freestyle.mp3", fourteen, context);
            InsertSong(24, "24. Dark Clouds.mp3", fourteen, context);
            InsertSong(25, "25. Mind Blow.mp3", fourteen, context);

            // Album 15
            Album fifteen = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 15);

            InsertSong(1, "01 All I Have Seen.mp3", fifteen, context);
            InsertSong(2, "02 Dis Is Killa.mp3", fifteen, context);
            InsertSong(3, "03 My Life Is Fucked.mp3", fifteen, context);
            InsertSong(4, "04 I Got U.mp3", fifteen, context);
            InsertSong(5, "05 Diss 2 Fat Sikhs.mp3", fifteen, context);
            InsertSong(6, "06 Bitten By A Snake.mp3", fifteen, context);
            InsertSong(7, "07 Ovarian Cancer.mp3", fifteen, context);
            InsertSong(8, "08 Bitch Singh.mp3", fifteen, context);
            InsertSong(9, "09 Death Is Approaching.mp3", fifteen, context);
            InsertSong(10, "10 Hood Legends.mp3", fifteen, context);
            InsertSong(11, "11 Murda Ya.mp3", fifteen, context);
            InsertSong(12, "12 We Spit Dat Hard Shit.mp3", fifteen, context);
            InsertSong(13, "13 Letter To B Man.mp3", fifteen, context);
            InsertSong(14, "14 Letter To B Man (Part 2).mp3", fifteen, context);
            InsertSong(15, "15 Letter To B Man (Part 3).mp3", fifteen, context);
            InsertSong(16, "16 Pains & Struggle.mp3", fifteen, context);
            InsertSong(17, "17 Pains & Struggle Remix.mp3", fifteen, context);
            InsertSong(18, "18 We Aint Living Right.mp3", fifteen, context);
            InsertSong(19, "19 Khalsa Aid Tribute.mp3", fifteen, context);
            InsertSong(20, "20 Neva Understand My Pain.mp3", fifteen, context);
            InsertSong(21, "21 Neva Undastand My Pain Part 2.mp3", fifteen, context);
            InsertSong(22, "22 Our Hometown.mp3", fifteen, context);
            InsertSong(23, "23 Make Em Lean Back Wid Skengz.mp3", fifteen, context);
            InsertSong(24, "24 Real Killers.mp3", fifteen, context);
            InsertSong(25, "25 Real Talk (Hard Shit).mp3", fifteen, context);
            InsertSong(26, "26 Da Murder Plot.mp3", fifteen, context);
            InsertSong(27, "27 Natural Born Killers.mp3", fifteen, context);
            InsertSong(28, "28 Natural Born Killers Instrumental.mp3", fifteen, context);
            InsertSong(29, "29 Top Boyz Freestyle.mp3", fifteen, context);

            // Album 16
            Album sixteen = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 16);

            InsertSong(1, "01 Interview By Akaal Org.mp3", sixteen, context);
            InsertSong(2, "02 Interview By LHM.mp3", sixteen, context);
            InsertSong(3, "03 Interview & Exclusive 3style In 2011.mp3", sixteen, context);
            InsertSong(4, "04 2nd Interview By LHM.mp3", sixteen, context);
            InsertSong(5, "05 Killa Explains Why Sikh Unit Is One Of Da Realest Gangs.mp3", sixteen, context);
            InsertSong(6, "06 I am Not Racist But I Am Paronoid.mp3", sixteen, context);
            InsertSong(7, "07 Killa Confronts FB Haterz.mp3", sixteen, context);
            InsertSong(8, "08 Killa Argues Wid a Sikh Womens Association!.mp3", sixteen, context);
            InsertSong(9, "09 Extracts From 3 Different Interviews.mp3", sixteen, context);
            InsertSong(10, "10 Killa Talks About Dress sense.mp3", sixteen, context);
            InsertSong(11, "11 Killa Confronts Bullshit Rumors.mp3", sixteen, context);
            InsertSong(12, "12 Killa Talks On Attempt On His Life.mp3", sixteen, context);
            InsertSong(13, "13 We Are Not Your Role Models.mp3", sixteen, context);
            InsertSong(14, "14 Da Gap Between Sikhi & Da Streetz.mp3", sixteen, context);
            InsertSong(15, "15 The Last Interview.mp3", sixteen, context);
            InsertSong(16, "16 Killa 3styles Part 1.mp3", sixteen, context);
            InsertSong(17, "17 Killa 3styles Part 2.mp3", sixteen, context);
            InsertSong(18, "18 Killa 3styles Part 3.mp3", sixteen, context);
            InsertSong(19, "19 Last Ever 3style!.mp3", sixteen, context);

            // Album 17
            Album seventeen = context.Albums.Include(a => a.Songs).Single(a => a.AlbumNumber == 17);

            InsertSong(1, "01 Holler.mp3", seventeen, context);
            InsertSong(2, "02 Tell Me Do U Wanna.mp3", seventeen, context);
            InsertSong(3, "03 World Is So Cold.mp3", seventeen, context);
            InsertSong(4, "04 Lonely Daze.mp3", seventeen, context);
            InsertSong(5, "05 G. Thang.mp3", seventeen, context);
            InsertSong(6, "06 Try Again.mp3", seventeen, context);
            InsertSong(7, "07 Coulda Been.mp3", seventeen, context);

            context.SaveChanges();
        }

        private void InsertSong(int trackNumber, string fileName, Album album, DatabaseContext context)
        {
            if (album.Songs.SingleOrDefault(s => s.Name == fileName) == null)
            {
                context.Songs.AddOrUpdate(new Song {TrackNumber = trackNumber, Name = fileName, Album = album});
            }
        }

        private void InsertAlbums(DatabaseContext context)
        {
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 1, Name = "01 From Da Streets 2 A Sikh (2005)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 2, Name = "02 Da Movement (2006)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 3, Name = "03 For Da Streets By Da Streets (2007)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 4, Name = "04 No More Mr Nice Guy (2008)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 5, Name = "05 2 Sides 2 Every Guy (2008)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 6, Name = "06 Kill Or Be Killed (2008)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 7, Name = "07 Killa - Public Demand (2008)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 8, Name = "08 Sikh Unit - Singhs Talking Da Hardest (2009)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 9, Name = "09 Da Reflection of Da Streetz (2009)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 10, Name = "10 Da Last Of A Dying Breed (2010)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 11, Name = "11 Emotions (2010)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 12, Name = "12 Da Singhdicate (2011)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 13, Name = "13 Product Of My Environment (2012)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 14, Name = "14 Da family Guy (2013)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 15, Name = "15 Da Lost Tapes (2013)" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 16, Name = "16 Killa - Interviews & 3styles CD" });
            context.Albums.AddOrUpdate(a => a.Name, new Album { AlbumNumber = 17, Name = "17 Killaz Fav Instrumentals" });

            context.SaveChanges();
        }
    }
}