## Unity Build Automation
**Unity Build Automation** is our new name for **Cloud Build**. 

Unity Build Automation is a continuous integration that automatically creates multi-platform builds in the Cloud in minutes. You can point Build Automation toward your version control system to:

- Automate new builds
- Build faster
- Catch problems earlier
- Iterate on your builds more efficiently with agility

Build Automation supports most popular version control systems and builds for multiple platforms simultaneously, including iOS.


### What is CI/CD ?
**CI/CD**, or **continuous integration/continuous delivery or deployment**, is a software development practice enabled by **automation**. Frequent, reliable updates accelerate release cycles via continuous code delivery.

Continuous integration requires developers to frequently checkin/commit their units of code to a central shared repository many times a day. 


https://unity.com/solutions/what-is-ci-cd

### Unity’s Cloud Build service 
You can **build your project on your own computer**, or you can use **Unity’s Cloud Build service which provides automated build** generation and continuous integration for your Unity projects.


Build Automation connects to either Unity VCS or your source control system and monitors that system for changes to your project. When it detects changes to your project, Build Automation downloads and builds your project for your target platforms. When the builds are complete, Build Automation notifies you of the results and links to download, share, and install the builds. If there are errors, Build automation informs you immediately, so you can quickly fix them, commit the changes, and trigger new builds.

You can integrate different software for notifications such as **Slack, Discord, and Jira**. \
https://docs.unity3d.com/Manual/UnityIntegrations.html


### How Build Automation works?
1. **SetUp**: Point Build Automation to your version control system.
2. **Trigger**: Commit a change to your project.
3. **Build**: On trigger, a build is automatically created.
4. **Deploy**: Your team is notified when the build is complete and ready to use.


### Using Addressables in Unity Build Automation
> **Addressable Assets** are assets that have a unique address which you can use to load them from **local or remote AssetBundles**.

https://docs.unity.com/devops/en/manual/addressables-in-build-automation


### Unity build server
Build Server can scale your on-prem build capacity with on-demand or automated builds on dedicated network hardware.

Unity Build Server is a more cost-effective licensing solution for building Unity projects that helps studios iterate quickly and complete projects faster by offloading computationally expensive project builds to network hardware.

https://unity.com/products/unity-build-server

### ref 
https://docs.unity3d.com/Manual/UnityCloudBuild.html

https://docs.unity.com/devops/en/manual/unity-build-automation

https://unity.com/solutions/ci-cd

https://circleci.com/blog/cicd-for-unity-projects/?utm_source=google&utm_medium=sem&utm_campaign=sem-google-dg--uscan-en-dsa-tROAS-auth-nb&utm_term=g_-_c__dsa_&utm_content=&gclid=CjwKCAjwx_eiBhBGEiwA15gLNxta0rs9uj6SOOYtCqsQ_KDObqzfA7x0kj4x6FqWmCAXbPjSK4-jZRoCdgIQAvD_BwE
