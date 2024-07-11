import SignIn from "./SignIn";
import SignUp from "./SignUp";
import Home from "./Home";
import Counter from "./Counter/Counter";
import Contact from "./Contact";

const homeChildren = [
  {
    path: "counter",
    element: <Counter />,
  },
  {
    path: "contact",
    element: <Contact />,
  },
];

const Routes = [
  {
    path: "/",
    element: <Home />,
    children: homeChildren,
  },
  {
    path: "/home",
    element: <Home />,
    children: homeChildren,
  },
  {
    path: "/signin",
    element: <SignIn />,
  },
  {
    path: "/signup",
    element: <SignUp />,
  },
];

export default Routes;
