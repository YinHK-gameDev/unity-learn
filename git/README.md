## Version control for unity - Git / Github

Once in the directory of your existing project proceed to execute the following commands below:

Initialize Git (Version Control)
```
git init
```
Create a .gitignore File for Unity

You can find the latest gitignore content for Unity here:  **https://github.com/github/gitignore/blob/master/Unity.gitignore**

Copy and paste the syntax into the console and then type the following to close the creation of the gitignore file.

Add All Your Files To Be Monitored
```
git add .
```


### Git for Unity
A Git client for your Unity Editor. 

https://github.com/spoiledcat/git-for-unity \
https://github.com/unity-technologies/git-for-unity \
https://github.com/spoiledcat/git-for-unity


### Large file
using `git lfs` (large file storage) for file larger than 100 Gb.  regular checkins on files smaller than 100mb and lfs on files larger than that. There's a free tier of LFS per repo and it's enough to cover personal projects. If you really need extra data it's only like $5/mo

https://www.reddit.com/r/gamedev/comments/yjsx0p/should_i_use_github_with_unity_if_i_am_working_by/


### Using gitignore
Using gitignore, it only commits the essential files. Without gitignore, the first commit of an empty project will be a few thousand files and so LFS is needed. With the right gitignore settings it’s about 40 files and you can commit like normal. 


### ref 

https://cadacreate.medium.com/how-to-add-existing-unity-project-to-github-916ad75160e7

https://unityatscale.com/unity-version-control-guide/how-to-setup-unity-project-on-github/
