# InfoTrackSEOCount

Chrome version 83 is required to run this application.

//Input required
Input your search keyword in the keyword text box - "Online title search"
Input the URL which you would like to count in the search result. - "https://https://www.infotrack.com.au/"

Select Google search fromr radio button and then press Search.

Result with the count will appear on next page.

Notes: I have used adaptor pattern in my application.
For now I have used radio button to switch between Bing and Google search but code is available for google search only.
We can write another similar adaptor for Bing search or any other search in future.
App is completely extendable, we can add a dropdown on the UI to select between different search engines if we have multiple search engine to choose from.
I have used autofac to inject the dependencies.
I have used chrome webdriver to automate the google search by entering the search keywords. 
Once Google results are captured then I have checked the appearance of the input URL in teh results.
