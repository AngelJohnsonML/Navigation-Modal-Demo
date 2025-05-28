**.NET MAUI Modal Navigation with Result Demo**

This project demonstrates how to perform modal navigation in .NET MAUI and return a result from a modal page (Page1) to the calling page (MainPage). Since modal navigation (PushModalAsync) doesn't natively return a value when the page is closed, this demo uses TaskCompletionSource<T> to simulate dialog-style behavior — similar to how ShowDialog() works in WPF.

**How It Works**
1. The main page (MainPage) navigates to Page1 using PushModalAsync on the click of "Navigate to Page1" button.

2. Page1 exposes a Task<string> via a TaskCompletionSource<string>, which is completed when the user takes an action i.e. clicking "Return Result" button.

3. Once the task is completed and the modal is popped (PopModalAsync()), the main page continues and handles the returned result.

**Why Use This**

This pattern allows you to handle asynchronous user input from modal pages in a clean and structured way, making it ideal for login pages, confirmation dialogs, or any scenario where the main page needs to wait for a result before proceeding.
