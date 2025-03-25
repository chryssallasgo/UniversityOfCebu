## University of Cebu Application
A desktop application for managing college database information. Includes features like user login, 
registration, and validation to prevent duplicate entries.

## How to Run the Project
1. Clone the repository:
   git clone https://github.com/<your-username>/UniversityOfCebu.git
2. Open the project in Visual Studio 2022:
   File > Open > Project/Solution > Select the solution file (.sln).
3. Run the application:
   Press Ctrl+F5 or click "Start" to run the program.

## Git Workflow
### Branching Strategy
- The `main` branch is the stable working version of the project.
- Each team member creates their own feature branch (e.g., `feature-branch-login`).

### How to Work on a Feature
1. Create a new branch:
   git checkout -b feature-branch-name
2. Make changes, commit them, and push to the remote repository:
   git add .
   git commit -m "feat: added login form"
   git push origin feature-branch-name

### Pull Request Process
1. Go to the "Pull Requests" tab on GitHub and click "New Pull Request."
2. Compare your branch with `main`.
3. Submit the pull request (PR).
4. The other team member reviews the PR and provides feedback.
5. After approval, merge the PR into the `main` branch.

### Updating Your Local Main Branch
1. Switch to the `main` branch:
   git checkout main
2. Pull the latest changes:
   git pull origin main
