﻿namespace Agenda.Clinica.Data;


public class ScheduleData
{
    public List<AppointmentData> GetScheduleData()
    {
        List<AppointmentData> appData = new List<AppointmentData>();
        appData.Add(new AppointmentData
        {
            Id = 1,
            Subject = "Explosion of Betelgeuse Star",
            StartTime = new DateTime(2023, 8, 11, 9, 30, 0),
            EndTime = new DateTime(2023, 8, 11, 11, 0, 0),
            CategoryColor = "#1aaa55"
        });
        appData.Add(new AppointmentData
        {
            Id = 2,
            Subject = "Thule Air Crash Report",
            StartTime = new DateTime(2023, 8, 12, 12, 0, 0),
            EndTime = new DateTime(2023, 8, 12, 14, 0, 0),
            CategoryColor = "#357cd2"
        });
        appData.Add(new AppointmentData
        {
            Id = 3,
            Subject = "Blue Moon Eclipse",
            StartTime = new DateTime(2023,8, 13, 9, 30, 0),
            EndTime = new DateTime(2023, 8, 13, 11, 0, 0),
            CategoryColor = "#7fa900"
        });
        appData.Add(new AppointmentData
        {
            Id = 4,
            Subject = "Meteor Showers in 2023",
            StartTime = new DateTime(2023, 8, 14, 13, 0, 0),
            EndTime = new DateTime(2023, 8, 14, 14, 30, 0),
            CategoryColor = "#ea7a57"
        });
        appData.Add(new AppointmentData
        {
            Id = 5,
            Subject = "Milky Way as Melting pot",
            StartTime = new DateTime(2023, 8, 15, 12, 0, 0),
            EndTime = new DateTime(2023,8, 15, 14, 0, 0),
            CategoryColor = "#00bdae"
        });
        appData.Add(new AppointmentData
        {
            Id = 6,
            Subject = "Mysteries of Bermuda Triangle",
            StartTime = new DateTime(2023, 2, 15, 9, 30, 0),
            EndTime = new DateTime(2023, 2, 15, 11, 0, 0),
            CategoryColor = "#f57f17"
        });
        appData.Add(new AppointmentData
        {
            Id = 7,
            Subject = "Glaciers and Snowflakes",
            StartTime = new DateTime(2023, 2, 16, 11, 0, 0),
            EndTime = new DateTime(2023, 2, 16, 12, 30, 0),
            CategoryColor = "#1aaa55"
        });
        appData.Add(new AppointmentData
        {
            Id = 8,
            Subject = "Life on Mars",
            StartTime = new DateTime(2023, 2, 17, 9, 0, 0),
            EndTime = new DateTime(2023, 2, 17, 10, 0, 0),
            CategoryColor = "#357cd2"
        });
        appData.Add(new AppointmentData
        {
            Id = 9,
            Subject = "Alien Civilization",
            StartTime = new DateTime(2023, 2, 19, 11, 0, 0),
            EndTime = new DateTime(2023, 2, 19, 13, 0, 0),
            CategoryColor = "#7fa900"
        });
        appData.Add(new AppointmentData
        {
            Id = 10,
            Subject = "Wildlife Galleries",
            StartTime = new DateTime(2023, 2, 21, 11, 0, 0),
            EndTime = new DateTime(2023, 2, 21, 13, 0, 0),
            CategoryColor = "#ea7a57"
        });
        appData.Add(new AppointmentData
        {
            Id = 11,
            Subject = "Best Photography 2023",
            StartTime = new DateTime(2023, 2, 22, 9, 30, 0),
            EndTime = new DateTime(2023, 2, 22, 11, 0, 0),
            CategoryColor = "#00bdae"
        });
        appData.Add(new AppointmentData
        {
            Id = 12,
            Subject = "Smarter Puppies",
            StartTime = new DateTime(2023, 2, 9, 10, 0, 0),
            EndTime = new DateTime(2023, 2, 9, 11, 30, 0),
            CategoryColor = "#f57f17"
        });
        appData.Add(new AppointmentData
        {
            Id = 13,
            Subject = "Myths of Andromeda Galaxy",
            StartTime = new DateTime(2023, 2, 7, 10, 30, 0),
            EndTime = new DateTime(2023, 2, 7, 12, 30, 0),
            CategoryColor = "#1aaa55"
        });
        appData.Add(new AppointmentData
        {
            Id = 14,
            Subject = "Aliens vs Humans",
            StartTime = new DateTime(2023, 2, 5, 10, 0, 0),
            EndTime = new DateTime(2023, 2, 5, 11, 30, 0),
            CategoryColor = "#357cd2"
        });
        appData.Add(new AppointmentData
        {
            Id = 15,
            Subject = "Facts of Humming Birds",
            StartTime = new DateTime(2023, 2, 20, 9, 30, 0),
            EndTime = new DateTime(2023, 2, 20, 11, 0, 0),
            CategoryColor = "#7fa900"
        });
        appData.Add(new AppointmentData
        {
            Id = 16,
            Subject = "Sky Gazers",
            StartTime = new DateTime(2023, 2, 23, 11, 0, 0),
            EndTime = new DateTime(2023, 2, 23, 13, 0, 0),
            CategoryColor = "#ea7a57"
        });
        appData.Add(new AppointmentData
        {
            Id = 17,
            Subject = "The Cycle of Seasons",
            StartTime = new DateTime(2023, 2, 12, 5, 30, 0),
            EndTime = new DateTime(2023, 2, 12, 7, 30, 0),
            CategoryColor = "#00bdae"
        });
        appData.Add(new AppointmentData
        {
            Id = 18,
            Subject = "Space Galaxies and Planets",
            StartTime = new DateTime(2023, 2, 12, 17, 0, 0),
            EndTime = new DateTime(2023, 2, 12, 18, 30, 0),
            CategoryColor = "#f57f17"
        });
        appData.Add(new AppointmentData
        {
            Id = 19,
            Subject = "Lifecycle of Bumblebee",
            StartTime = new DateTime(2023, 2, 15, 6, 0, 0),
            EndTime = new DateTime(2023, 2, 15, 7, 30, 0),
            CategoryColor = "#7fa900"
        });
        appData.Add(new AppointmentData
        {
            Id = 20,
            Subject = "Sky Gazers",
            StartTime = new DateTime(2023, 2, 15, 16, 0, 0),
            EndTime = new DateTime(2023, 2, 15, 18, 0, 0),
            CategoryColor = "#ea7a57"
        });
        return appData;
    }

   
}
