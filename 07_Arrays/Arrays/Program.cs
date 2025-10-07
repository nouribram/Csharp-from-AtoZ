/**  Debugging in React Native
Debugging helps find and fix issues in your code, UI, and performance. 
React Native includes built-in and external tools for effective debugging and logging.
*/

console.log("Debugging helps identify and fix errors in React Native apps.");



/** Using Console Logs Effectively
Console methods help you inspect code behavior quickly.
Use them to check variable values, track execution flow, or detect errors.
*/

console.log("App started");
console.warn("Low memory warning");
console.error("Network request failed");
console.table([{ id: 1, name: "John" }, { id: 2, name: "Jane" }]);



/** React Native Developer Menu
The Developer Menu gives quick access to reload, inspect UI, and enable remote debugging.
Open it by shaking the device or pressing:
- Cmd + M (Android Emulator)
- Cmd + D (iOS Simulator)
*/

console.log("Use Developer Menu → Debug JS Remotely to open Chrome DevTools.");



/**  React Native Debugger
An all-in-one debugging tool that includes Chrome DevTools and Redux DevTools.
To install:
brew install --cask react-native-debugger
Then start it before running your app.
*/

console.log("React Native Debugger connected to localhost:8081");
// You can now inspect Redux actions, state, network, and console logs.



/**  Using Flipper for Debugging
Flipper is Meta’s official debugging tool for React Native.
It provides logs, layout inspection, network requests, and plugin support.
Install it and connect your app using:
npm install --save react-native-flipper
*/

console.log("Flipper connected. You can now inspect logs, UI layout, and network requests.");



/**  Handling Errors Gracefully
Always handle errors to prevent app crashes.
Use try/catch blocks for async operations or add error boundaries for UI.
*/

try {
  throw new Error("Something went wrong");
} catch (error) {
  console.error("Caught error:", error.message);
}

class ErrorBoundary extends React.Component {
  componentDidCatch(error, info) {
    console.log("Error caught by boundary:", error);
  }
  render() {
    return this.props.children;
  }
}



/**  Best Practices for Debugging and Logging
1. Log only useful information.
2. Remove logs before production.
3. Use environment checks like __DEV__.
4. Monitor app performance and memory.
5. Use Sentry or Bugsnag for crash reporting.
*/

if (__DEV__) {
  console.log("Development environment log");
}
