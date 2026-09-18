# Jeremiah Romulo — MVC Portfolio Application


Features
---

* **Table of Contents** (Home page) — all projects grouped by category (Prelim, Midterm, Prefinal), with anchor links.
* **Project detail pages** — one page per project with a thumbnail, description, and a link to the GitHub repository.
* **Comment section** — every project detail page has a comment list and a form to add new comments (stored in memory for the life of the running app).
* **Hardcoded login** — the whole site is protected by cookie-based authentication using a single hardcoded account (see below).

##Login Credentials

|Field|Value|
|-|-|
|Username|`admin`|
|Password|`Portfolio@2026`|



## Projects Included

All 14 projects from the submitted GitHub repository list are cataloged in
`Data/ProjectData.cs`, grouped into **Prelim**, **Midterm**, and **Prefinal**
categories. Each entry includes a name, short description, GitHub link, and a
generated thumbnail image. Edit the `Description` and `Category` fields in
`ProjectData.cs` to fine-tune the write-up for each repository.

Comments and login sessions are stored in memory only — they reset
whenever the application restarts. This keeps the demo simple and dependency-free.



