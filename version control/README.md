## Version control for Unity project


There are several options to save and manage your Unity projects with version control. These include using cloud-based solutions, local repositories, or specialized tools. Below are some popular solutions for saving and applying version control to Unity projects:


#### Unity Version Control 

-   **Description:** Unity's built-in version control system, designed specifically for game development. It handles large files and binary assets well, making it ideal for Unity projects.
-   **Features:**
    -   Cloud and local repositories.
    -   Visual merging tools for scene and prefab files.
    -   Free tier for small teams (up to 3 users).
-   **Best For:** Unity teams looking for deep integration and scalability.

https://unity.com/how-to/redeem/version-control \
https://unity.com/solutions/version-control

#### **GitHub (or Other Git Services like GitLab, Bitbucket, etc.)**

-   **Description:** Git-based version control is widely used and versatile but can struggle with large binary files.
-   **Features:**
    -   Free for public and private repositories (limits may apply).
    -   Excellent for code management.
    -   Use **Git LFS** (Large File Storage) to manage Unity's binary assets.
-   **How to Use:**
    -   Initialize a Git repository in your Unity project folder.
    -   Add a `.gitignore` file specifically configured for Unity.
    -   Push the repository to GitHub or other Git hosting services.
-   **Best For:** Developers familiar with Git and working with smaller Unity projects.

#### Unity Cloud
Flexible and extensible tools streamline every aspect of the multiplayer game development journey, from concept and prototyping through launch and live operations.


https://unity.com/products/unity-cloud
#### **External Cloud Storage Services**

-   **Description:** Use platforms like **Google Drive**, **Dropbox**, or **OneDrive** to save and share your Unity projects.
-   **Features:**
    -   Manual versioning by saving project files with version tags.
    -   Limited or no automated merging/version control.
-   **How to Use:**
    -   Save your Unity project folder to a synchronized cloud directory.
-   **Best For:** Solo developers needing simple backup solutions (not ideal for version control).

#### **Perforce (Helix Core)**

-   **Description:** A version control system tailored for handling large files and binary assets, commonly used in professional game development.
-   **Features:**
    -   Excellent for large teams and projects.
    -   Handles massive Unity projects with ease.
-   **How to Use:**
    -   Install Perforce (P4V) and set up a server.
    -   Connect your Unity project to Perforce.
-   **Best For:** Professional game studios or teams with large projects.

https://get.assembla.com/perforce/

#### **Comparison Table**

| **Option** | **Version Control** | **Cloud Storage** | **Best Use Case** |
| --- | --- | --- | --- |
| Unity Version Control | Yes | Yes | Small to large Unity teams |
| GitHub/GitLab/Bitbucket | Yes | Yes | Code-heavy or small Unity projects |
| Unity Cloud | Yes | Yes | Beginners or small teams (<3 GB) |
| External Cloud Storage | No (manual) | Yes | Simple backup for solo developers |
| Perforce | Yes | Yes | Large projects or professional teams |

#### **Recommendations**

-   For **solo developers or small teams**: Start with **Unity Version Control** or **Unity Cloud**.
-   For **experienced developers**: Use **GitHub** with **Git LFS** for flexibility and familiarity.
-   For **professional teams**: Consider **Unity Version Control** or **Perforce** for scalability and performance.

#### Sourcetree
a free Git and Mercurial client developed by Atlassian, providing a graphical user interface (GUI) for managing repositories. It's especially useful for developers who prefer not to use command-line Git or Mercurial commands.


### ref
https://www.youtube.com/watch?v=9IvXupmgl88

