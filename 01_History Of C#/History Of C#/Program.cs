// =============================================
// Intro to C# — A Quick Overview
// =============================================

// 1. What is C#?
// C# is a modern, object-oriented programming language
// developed by Microsoft in the year 2000 as part of its .NET initiative.
// It is designed for building a wide range of applications: desktop, web, mobile, and games.
// C# combines the power of C++ with the simplicity of Java, making it beginner-friendly yet powerful.

// 2. Why Learn C#?
// - Versatile: Build web apps, mobile apps, games, desktop software.
// - Industry demand: Widely used in enterprise applications.
// - Strong typing & safety features: Reduce runtime errors.
// - Huge community and learning resources.
// - Works seamlessly with .NET ecosystem.

// 3. Key Features of C#
// - Object-Oriented: Encapsulation, inheritance, polymorphism.
// - Rich standard library.
// - Strongly typed language.
// - Automatic memory management (Garbage Collection).
// - Modern features: LINQ, async/await, pattern matching, records, etc.

// 4. History of C#
// - Released in 2000 with .NET Framework 1.0.
// - Created by Anders Hejlsberg (also created Turbo Pascal and Delphi).
// - Continuously evolving — C# 12 and newer versions keep adding modern capabilities.
// - Part of the open-source .NET platform (since 2014).

// 5. Popular Uses of C#
// - Web applications (with ASP.NET Core).
// - Windows desktop apps (WinForms, WPF, MAUI).
// - Game development (Unity engine).
// - Mobile apps (Xamarin, MAUI).
// - Cloud services (Azure Functions, APIs).
// - IoT and embedded systems.


// =============================================
// Minimal Demo Program
// =============================================
using System;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Intro to C#!");
            Console.WriteLine("C# is modern, object-oriented, and super versatile.");
        }
    }
}



/*

/*
===========================================
 Intro to React – Tutorial
===========================================

About React
----------------------
- React is a JavaScript library for building user interfaces.
- Developed by Facebook.
- Component-based, reusable, and efficient.
- Uses a Virtual DOM for fast rendering.
- Powers web apps, mobile apps (React Native), and more.
*/

// Example minimal React component

import React from "react";

function App() {
  return <h1>Hello, React!</h1>;
}

/*
Components & JSX
---------------------------
- Components are the building blocks of a React app.
- Functional components → recommended modern approach.
- Class components → legacy, but support lifecycle methods.
- JSX: lets you write HTML-like syntax inside JavaScript.
*/

// Functional component
function Welcome() {
  return <h1>Hello!</h1>;
}

/*
Props & State
------------------------
- Props: data passed from parent to child, read-only.
- Example: <Greeting name="Nour" />
- State: internal data in a component that can change and trigger re-renders.
*/

// Props example
function Greeting(props) {
  return <h2>Hello, {props.name}!</h2>;
}

// State example with useState hook
import { useState } from "react";

function Counter() {
  const [count, setCount] = useState(0);
  return (
    <>
      <p>Count: {count}</p>
      <button onClick={() => setCount(count + 1)}>Increase</button>
    </>
  );
}

/*
Hooks & Lifecycle
----------------------------
- Hooks are the modern way to manage state & side effects in functional components.
    - useState() → state
    - useEffect() → side effects & lifecycle behavior
    - useContext() → global state
- Class components use lifecycle methods: Mounting, Updating, Unmounting
*/

import { useEffect } from "react";

function Timer() {
  useEffect(() => {
    console.log("Component mounted");
    return () => console.log("Component unmounted");
  }, []);
  return <p>Timer running...</p>;
}

/*
Event Handling & Conditional Rendering
-------------------------------------------------
- React events use camelCase:
    <button onClick={handleClick}>Click</button>
- Conditional rendering can be done with ternary or &&
*/

function LoginButton({ isLoggedIn }) {
  return (
    <div>
      {isLoggedIn ? <h3>Welcome back!</h3> : <button>Login</button>}
    </div>
  );
}

/*
Lists & Keys
-----------------------
- Use .map() to render lists of elements.
- Keys help React identify each element for efficient updates.
*/

const items = [
  { id: 1, name: "Apple" },
  { id: 2, name: "Banana" },
];

function ItemList() {
  return (
    <ul>
      {items.map((item) => (
        <li key={item.id}>{item.name}</li>
      ))}
    </ul>
  );
}

/*
Advanced Concepts
----------------------------
- Context API → global state without prop drilling.
- Lazy loading & Suspense → code splitting.
- Portals → render outside the main DOM tree.
- Custom Hooks → reusable logic.
*/

// Example Context usage (simplified)
import { createContext, useContext } from "react";
const MyContext = createContext("Default Value");

function ContextExample() {
  const value = useContext(MyContext);
  return <p>Context value: {value}</p>;
}

/*
Performance & Debugging
----------------------------------
- Optimize with React.memo(), useCallback(), useMemo().
- Use React DevTools to inspect components, props, and state.
- Keep components small, reusable, and easy to read.
*/

/*
 Best Practices & Tips
--------------------------------
✅ Start with functional components + hooks
✅ Keep state local unless needed globally
✅ Avoid unnecessary re-renders
✅ Use descriptive prop names
✅ Test components (Jest + React Testing Library)
✅ Deploy with Netlify, Vercel, or GitHub Pages
*/

export default App;




