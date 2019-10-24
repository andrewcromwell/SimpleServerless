## Overview

This is a simple serverless application using React on the front-end and an Azure Function on the backend.

The Azure function lives in `azure-function/GermanWord`.
The front-end code lives in `german_react_spa`.
## Getting Going
#### Front-end
I'm assuming you have VSCode installed with [Azure Storage extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurestorage).
1. To build the front-end code, run
```
npm install
npm run build
```
2. To deploy, right-click on the `build` folder and click *Deploy to Static Website*

#### Back-end
I'm assuming you have Visual Studio 2019 installed with the Azure Development workload.
1. To build the back-end code, open the project in VS2019 and build with CTRL+Shift+B.
2. To deploy, right-click on the project and click *Publish*.

## Roadblock

CORS usually won't let a front-end application make requests to different websites. That is, unless the requested resource uses `Access-Control-Allow-Origin: *`
It would be better if we could be more selective about which sites are allowed to access our Azure function.
## Resolution

Fortunately, Microsoft has a [way](https://docs.microsoft.com/en-us/azure/azure-functions/functions-how-to-use-azure-function-app-settings) to let you specify which sites are allowed to access your Azure functions, and all within the Azure portal. No code changes needed.

More specifically, you just:
1. navigate to your function,
2. click on the *Platform Features* tab,
3. under *API*, click *CORS*,
4. add the name of your static website.

## Room for Improvement
* There should be an actual database
* The app should allow CRUD, not just R
* The front-end should have more styling
* The front-end should have some real tests
* The function shouldn't be hard-coded, but should rather be held in config
