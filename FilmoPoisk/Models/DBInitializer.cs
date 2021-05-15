using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Filmopoisk.Models;

namespace FilmoPoisk.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            Actor actor1 = new Actor { Name = "Брэд Питт", Country = "США", BirthDate = new DateTime(1963, 12, 18) };
            Actor actor2 = new Actor { Name = "Джейсон Стетхем", Country = "США", BirthDate = new DateTime(1967, 7, 26) };
            Actor actor3 = new Actor { Name = "Хлоя Морец", Country = "США", BirthDate = new DateTime(1997, 2, 10) };

            context.Actors.Add(actor1);
            context.Actors.Add(actor2);

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
                Actors = new List<Actor>() { actor2 }
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
                Actors = new List<Actor>() { actor1, actor2 }
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
                Actors = new List<Actor>() { actor1 }
            };
           

            context.Films.Add(film1);
            context.Films.Add(film2);
            context.Films.Add(film3);

            base.Seed(context);
        }
    }
}