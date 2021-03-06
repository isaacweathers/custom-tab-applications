#  Development1. Clone this repository and create a new branch.2. `Open Ingeniux_Extensions_Development.sln` to add new controllers and/or views.3. Build the project in Visual Studio 11 or higher. To see the results of a newly built application be sure to refresh the Ingeniux installation using IIS Manager.4. Submit a pull request.# Installation The following are steps for installing the custom tab applications within Ingeniux.

## Installing the applications
1. Copy the 'SampleApp' folder to 'site/App_Data/xml/Custom.' Feel free to rename the 'SampleApp' folder.
2. From the Ingeniux authoring tool navigate to Administration > System Options > CMS > Custom Tabs > Management
3. Click on the '+' button in the bottom right corner.
4. To add the accessibility tab use the following values in the new form:
  ```
    Name: Accessibility
    URL: Apps/SampleApp/<Controller Name>/<View Name>
    Is Global: leave unchecked
    Location: CMS System
    Icon Relative Path: leave default value
  ```
  Replacing `<controller Name>` and `<View Name>` with the view and controller names of the desired tool (ie. CustomTab for the controller of the sample application, Index for the view).
5. Log out of Ingeniux or refresh the page.
6. Refresh the Ingeniux instance using IIS Manager to clear cahced data.

## Setting Application Permissions
1. Navigate to Administration > System Options > Custom Tabs > Permissioning.
2. Select the name of the application to set permissions on.
3. Use the admin only check box or custom tab visibility form to specify groups who will be able to use the selected tool.
