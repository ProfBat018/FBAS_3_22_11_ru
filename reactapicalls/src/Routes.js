import Home from "./Home";
import About from "./About";
import Login from "./Login";
import Register from "./Register";
import Movies from "./Movies";
import Rating from "./Rating";


const homeChildren = [
  {
    path: "about",
    element: <About />,
  },
  {
    path: "login",
    element: <Login />,
  },
  {
    path: "register",
    element: <Register />,
  },
  {
    path: "movies",
    element: <Movies />,
  },
  {
    path: "rating",
    element: <Rating />
  }
];

const routes = [
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
];

export default routes;