using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal static class PlanetService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Despite its proximity to the Sun, " +
                "Mercury is not the hottest planet in our solar system— that title belongs to nearby Venus, " +
                "thanks to its dense atmosphere. But Mercury is the fastest planet, zipping around the Sun every 88 Earth days. " +
                "Mercury is appropriately named for the swiftest of the ancient Roman gods.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new() 
                {
                    // Otsida kõikide planeetide kohta kirjeldus ja 
                    // täita muud andmed ära
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The hottest planet in our solar system",
                HeroImage = "venus.png",
                Description = "Venus is a cloud-swaddled planet named for a love goddess, " +
                "and often called Earth’s twin. But pull up a bit closer, and Venus turns hellish. " +
                "Our nearest planetary neighbor, the second planet from the Sun, has a surface hot enough to melt lead. " +
                "The atmosphere is so thick that, from the surface, the Sun is just a smear of light.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "Earth - our home planet",
                HeroImage = "earth.png",
                Description = "While Earth is only the fifth largest planet in the solar system, " +
                "it is the only world in our solar system with liquid water on the surface. " +
                "Just slightly larger than nearby Venus, Earth is the biggest of the four planets closest to the Sun, " +
                "all of which are made of rock and metal.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The only planet we know of inhabited entirely by robots",
                HeroImage = "mars.png",
                Description = "Mars is no place for the faint-hearted. It’s dry, rocky, and bitter cold. " +
                "The fourth planet from the Sun, Mars is one of Earth's two closest planetary neighbors (Venus is the other). " +
                "Mars is one of the easiest planets to spot in the night sky – it looks like a bright red point of light.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The largest planet in the solar system",
                HeroImage = "jupiter.png",
                Description = "Jupiter's stripes and swirls are actually cold, windy clouds of ammonia and water, " +
                "floating in an atmosphere of hydrogen and helium. " +
                "Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "Saturn has the most moons at 146",
                HeroImage = "saturn.png",
                Description = "It is not the only planet to have rings, but none are as spectacular or as complex as Saturn's. " +
                "Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium. " +
                "The farthest planet from Earth discovered by the unaided human eye, Saturn has been known since ancient times. " +
                "The planet is named for the Roman god of agriculture and wealth, who was also the father of Jupiter.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The planet appears to spin sideways",
                HeroImage = "uranus.png",
                Description = "Uranus is a very cold and windy planet. It is surrounded by faint rings," +
                " and more than two dozen small moons as it rotates at a nearly 90-degree angle from the plane of its orbit. " +
                "This unique tilt makes Uranus appear to spin on its side.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The first planet discovered with math",
                HeroImage = "neptune.png",
                Description = "Dark, cold and whipped by supersonic winds, giant Neptune is the eighth and most distant major planet orbiting our Sun. " +
                "More than 30 times as far from the Sun as Earth, Neptune is not visible to the naked eye. In 2011, Neptune completed its first 165-year orbit since its discovery. " +
                "The planet’s rich blue color comes from methane in its atmosphere, which absorbs red wavelengths of light, but allows blue ones to be reflected back into space.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
        };
    }
}
