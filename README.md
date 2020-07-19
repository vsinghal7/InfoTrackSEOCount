# InfoTrackSEOCount

Chrome version 84 is required to run this application. This application was created using Visual Studio 2019 .

//Input required
Input your search keyword in the keyword text box - "Online title search"
Input the URL which you would like to count in the search result. - "www.infotrack.com.au" 
URL format should be like mentioned above.

Select Google search from radio button and then press Search.

Result with the count will appear on next page in tabular format.

Notes: I have used adaptor pattern in my application.
For now I have used radio button to switch between Bing and Google search but code is available for google search only.
We can write another similar adaptor for Bing search or any other search in future.
App is completely extendable, we can add a dropdown on the UI to select between different search engines if we have multiple search engine to choose from.
I have used autofac to inject the dependencies.
I have used chrome webdriver to automate the google search by entering the search keywords. 
Path to screen shots.
![alt tag](https://raw.githubusercontent.com/vsinghal7/InfoTrackSEOCount/master/InfoTrackSEOResultsCount/SearchInput.PNG)

![alt tag](https://raw.githubusercontent.com/vsinghal7/InfoTrackSEOCount/master/InfoTrackSEOResultsCount/SearchOutput.PNG)
