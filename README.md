# dtt_ros_unity_sample
## Unity setup
To install the ROS Unity plugin, go to the package manager and then select **"add package from git url"** and the enter 
"https://github.com/msunkaradtt/dtt_ros_unity_plugin.git?path=/dtt.ros.unity.plugin" to install the plugin.

You should now see a **_robotics_** option available in the **Unity menu bar**. 

By default, the interfaces or messages folder is not included in the project. Use the following line to clone the folder:
```
git clone https://github.com/msunkaradtt/dtt_ros_interfaces.git
```

Upon cloning this repo, the plugin should generate a **_RosMessages_** folder with c# classes representing the messages.

## 
## Happy coding!
