using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Filmopoisk.Models;
using System.IO;

namespace FilmoPoisk.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<FilmContext>
    {
        // Запись данных в БД с помощью подхода code first

        protected override void Seed(FilmContext context)
        {
            Actor Pitt = new Actor { Name = "Брэд Питт", Country = "США", BirthDate = new DateTime(1963, 12, 18) };
            Actor Stethem = new Actor { Name = "Джейсон Стетхем", Country = "США", BirthDate = new DateTime(1967, 7, 26) };
            Actor Morets = new Actor { Name = "Хлоя Морец", Country = "США", BirthDate = new DateTime(1997, 2, 10) };
            Actor Brody = new Actor { Name = "Эдриан Броуди", Country = "США", BirthDate = new DateTime(1973, 4, 14) };
            Actor Norton = new Actor { Name = "Эдвард Нортон", Country = "США", BirthDate = new DateTime(1969, 7, 18) };
            Actor Beil = new Actor { Name = "Кристиан Бэйл", Country = "Великобритания", BirthDate = new DateTime(1974, 1, 30) };
            Actor Gosling = new Actor { Name = "Райан Гослинг", Country = "Канада", BirthDate = new DateTime(1980, 11, 12) };

            context.Actors.Add(Pitt);
            context.Actors.Add(Stethem);
            context.Actors.Add(Morets);
            context.Actors.Add(Brody);
            context.Actors.Add(Norton);
            context.Actors.Add(Beil);
            context.Actors.Add(Gosling);


            Film film1 = new Film {
                Name = "Гнев человеческий",
                Country = "США",
                ReleaseDate = new DateTime(2021, 4, 22),
                Score = 7.3, 
                Genre = "Боевик, Триллер",
                Description = "Эйч — загадочный и холодный на вид джентльмен, но внутри него пылает жажда справедливости." +
                " Преследуя свои мотивы, он внедряется в инкассаторскую компанию, чтобы выйти на соучастников серии многомиллионных ограблений," +
                " потрясших Лос-Анджелес. В этой запутанной игре у каждого своя роль, но под подозрением оказываются все." +
                " Виновных же обязательно постигнет гнев человеческий.",
                Actors = new List<Actor>() { Stethem },
            };

            Film film2 = new Film {
                Name = "Большой куш",
                Country = "Великобритания",
                ReleaseDate = new DateTime(2000, 8, 23),
                Score = 8.5,
                Genre = "Триллер, Криминал",
                Description = "Четырехпалый Френки должен был переправить краденый алмаз из Англии в США своему боссу Эви, но, " +
                "сделав ставку на подпольный боксерский поединок, попадает в круговорот весьма нежелательных событий. Вокруг него " +
                "и его груза разворачивается сложная интрига с участием множества колоритных персонажей лондонского дна — русского гангстера," +
                " троих незадачливых грабителей, хитрого боксера и угрюмого громилы грозного мафиози. Каждый норовит в одиночку сорвать большой куш.",
                Actors = new List<Actor>() { Pitt, Stethem }
            };

            Film film3 = new Film {
                Name = "Бойцовский клуб",
                Country = "США",
                ReleaseDate = new DateTime(1999, 9, 10),
                Score = 8.6,
                Genre = "Триллер, Драма",
                Description = "Сотрудник страховой компании страдает хронической бессонницей и отчаянно пытается вырваться из мучительно скучной жизни." +
                " Однажды в очередной командировке он встречает некоего Тайлера Дёрдена — харизматического торговца мылом с извращенной философией." +
                " Тайлер уверен, что самосовершенствование — удел слабых, а единственное, ради чего стоит жить — саморазрушение.",
                Actors = new List<Actor>() { Pitt, Norton }
            };

            Film film4 = new Film
            {
                Name = "Отель «Гранд Будапешт»",
                Country = "США",
                ReleaseDate = new DateTime(2014, 2, 6),
                Score = 7.9,
                Genre = "Комедия, Детектив, Криминал",
                Description = "Фильм рассказывает об увлекательных приключениях легендарного консьержа Густава и его юного друга, портье Зеро Мустафы." +
                " Сотрудники гостиницы становятся свидетелями кражи и поисков бесценных картин эпохи Возрождения," +
                " борьбы за огромное состояние богатой семьи и… драматических изменений в Европе между двумя кровопролитными войнами XX века.",
                Actors = new List<Actor>() { Brody, Norton }
            };

            Film film5 = new Film
            {
                Name = "Игра на понижение",
                Country = "США",
                ReleaseDate = new DateTime(2015, 11, 12),
                Score = 7.3,
                Genre = "Комедия, Драма",
                Description = "История нескольких человек, которые независимо друг от друга предсказали мировой" +
                " экономический кризис 2008 года задолго до того, как о нем зашептались в кулуарах на Уолл-стрит." +
                " И предсказав, стали на нем зарабатывать.",
                Actors = new List<Actor>() { Beil, Gosling, Pitt }
            };

            Film film6 = new Film
            {
                Name = "Ла-Ла Ленд",
                Country = "США",
                ReleaseDate = new DateTime(2015, 11, 12),
                Score = 7.9,
                Genre = "Мюзикл, Драма, Комедия",
                Description = "Это история любви старлетки, которая между прослушиваниями подает кофе состоявшимся кинозвездам," +
                " и фанатичного джазового музыканта, вынужденного подрабатывать в заштатных барах." +
                " Но пришедший к влюбленным успех начинает подтачивать их отношения.",
                Actors = new List<Actor>() { Gosling }
            };

            Film film7 = new Film
            {
                Name = "Престиж",
                Country = "Великобритания",
                ReleaseDate = new DateTime(2006, 10, 17),
                Score = 8.5,
                Genre = "Фантастика, Триллер, Драма, Детектив",
                Description = "Роберт и Альфред - фокусники-иллюзионисты, которые на рубеже XIX и XX веков соперничали друг с другом в Лондоне." +
                " С годами их дружеская конкуренция на профессиональной почве перерастает в настоящую войну.Они готовы на все," +
                " чтобы выведать друг у друга секреты фантастических трюков и сорвать их исполнение.Непримиримая вражда," +
                " вспыхнувшая между ними, начинает угрожать жизни окружающих их людей…",
                Actors = new List<Actor>() { Beil }
            };


            context.Films.Add(film1);
            context.Films.Add(film2);
            context.Films.Add(film3);
            context.Films.Add(film4);
            context.Films.Add(film5);
            context.Films.Add(film6);
            context.Films.Add(film7);

            base.Seed(context);
        }
    }
}