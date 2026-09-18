using PortfolioApp.Models;

namespace PortfolioApp.Data
{
    /// <summary>
    /// Hardcoded catalog of the portfolio owner's GitHub projects.
    /// Edit the Description/Category text below to match each project more precisely.
    /// </summary>
    public static class ProjectData
    {
        public static readonly List<Project> All = new()
        {
            new Project
            {
                Id = 1,
                Name = "BSIT31E3 Prelim Activity 1",
                Category = "Prelim",
                Description = "First prelim activity for BSIT 31E3, focused on the fundamentals of MVC-based application structure and basic CRUD operations.",
                GitHubUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_A1_ROMULO_JEREMIAHH.git",
                ThumbnailUrl = "/images/project1.svg"
            },
            new Project
            {
                Id = 2,
                Name = "BSIT31E3 Prelim Activity 2",
                Category = "Prelim",
                Description = "Second prelim activity building on Activity 1, expanding the application's features and reinforcing MVC design patterns.",
                GitHubUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_A2_ROMULO_JEREMIAH.git",
                ThumbnailUrl = "/images/project2.svg"
            },
            new Project
            {
                Id = 3,
                Name = "BSIT31E3 Prelim Hands-on 1",
                Category = "Prelim",
                Description = "Hands-on prelim exercise applying course concepts in a guided lab setting, emphasizing controller and view logic.",
                GitHubUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_H1_ROMULO_JEREMIAH.git",
                ThumbnailUrl = "/images/project3.svg"
            },
            new Project
            {
                Id = 4,
                Name = "BSIT31E3 Prelim Hands-on 2",
                Category = "Prelim",
                Description = "Second hands-on prelim lab exercise, continuing to build practical skills with the MVC framework covered in class.",
                GitHubUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_H2_Romulo_Jeremiah.git",
                ThumbnailUrl = "/images/project4.svg"
            },
            new Project
            {
                Id = 5,
                Name = "BSIT31E3 Prelim Quiz 1",
                Category = "Prelim",
                Description = "Prelim quiz project demonstrating understanding of core programming and application-design topics from the first grading period.",
                GitHubUrl = "https://github.com/Softjeeem/BSIT_31E3_PRELIM_Q1_ROMULO_JEREMIAH.git",
                ThumbnailUrl = "/images/project5.svg"
            },
            new Project
            {
                Id = 6,
                Name = "BSIT31E3 Prelim Activity 3",
                Category = "Prelim",
                Description = "Third prelim activity, further practicing application structure, data handling, and view rendering.",
                GitHubUrl = "https://github.com/Softjeeem/BSIT31E3_PRELIM_A3_ROMULO_JEREMIAH.git",
                ThumbnailUrl = "/images/project6.svg"
            },
            new Project
            {
                Id = 7,
                Name = "IT Elective 2 Midterm Activity 1",
                Category = "Midterm",
                Description = "First midterm activity for IT Elective 2, applying more advanced application-development concepts introduced mid-semester.",
                GitHubUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_Midterm_A1_Romulo_Jeremiah.git",
                ThumbnailUrl = "/images/project7.svg"
            },
            new Project
            {
                Id = 8,
                Name = "IT Elective 2 (BSIT 31E3) Project",
                Category = "Midterm",
                Description = "A supporting project for IT Elective 2 that ties together concepts from the BSIT 31E3 curriculum into a working application.",
                GitHubUrl = "https://github.com/Softjeeem/IT_ELECTIVE_BSIT_31E3_Romulo_Jeremiah.git",
                ThumbnailUrl = "/images/project8.svg"
            },
            new Project
            {
                Id = 9,
                Name = "IT Elective 2 Midterm Quiz 2",
                Category = "Midterm",
                Description = "Midterm quiz project showcasing skills in application logic and feature implementation for the second grading milestone.",
                GitHubUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_MIDTERM_Q2_Romulo_Jeremiah.git",
                ThumbnailUrl = "/images/project9.svg"
            },
            new Project
            {
                Id = 10,
                Name = "IT Elective 2 Midterm Quiz 3",
                Category = "Midterm",
                Description = "Midterm quiz 3 project, continuing to build out application features and demonstrating problem-solving under exam conditions.",
                GitHubUrl = "https://github.com/Softjeeem/ROMULO_JEREMIAH_IT_ELECTIVE_2_MIDTERM_Q3.git",
                ThumbnailUrl = "/images/project10.svg"
            },
            new Project
            {
                Id = 11,
                Name = "IT Elective 2 Midterm Exam 3",
                Category = "Midterm",
                Description = "Third midterm examination project, a more comprehensive application built to demonstrate cumulative course learning.",
                GitHubUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_MIDTERM_EXAM_3_ROMULO.git",
                ThumbnailUrl = "/images/project11.svg"
            },
            new Project
            {
                Id = 12,
                Name = "IT Elective 2 Midterm Hands-on 1-3",
                Category = "Midterm",
                Description = "A combined set of midterm hands-on lab exercises (H1 through H3), covering iterative feature additions across three sessions.",
                GitHubUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_MIDTERM_H1_H2_H3.git",
                ThumbnailUrl = "/images/project12.svg"
            },
            new Project
            {
                Id = 13,
                Name = "Pre-Final Group Project",
                Category = "Prefinal",
                Description = "A collaborative pre-final project for IT Elective 2 (BSIT 31E3), built together with groupmates PJ Galang and Pelarca, bringing the semester's concepts into one larger application.",
                GitHubUrl = "https://github.com/ishpo29/IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo.git",
                ThumbnailUrl = "/images/project13.svg"
            },
            new Project
            {
                Id = 14,
                Name = "IT Elective 2 Pre-Final Exam",
                Category = "Prefinal",
                Description = "Individual pre-final examination project, demonstrating independent mastery of application development concepts covered throughout the term.",
                GitHubUrl = "https://github.com/Softjeeem/IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_ROMULO_JEREMIAH.git",
                ThumbnailUrl = "/images/project14.svg"
            },
        };

        public static Project? GetById(int id) => All.FirstOrDefault(p => p.Id == id);
    }
}
