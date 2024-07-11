import Home from "./Home";
import Login from "./Login";
import Register from "./Register";
import About from "./About";

const routes = [
  {
    path: "/",
    element: <Home />,
  },
  {
    path: "/home",
    element: <Home />,
    children: [
      {
        path: "contact",
        element: (
          <div>
            <h1>Contact</h1>
          </div>
        ),
      },
      {
        path: "about",
        element: (
          <div>
            <h1>About</h1>
          </div>
        ),
      },
      {
        path: "login",
        element: <Login />,
      },
      {
        path: "register",
        element: <Register />,
      },
    ],
  },
  {
    path: "/baxa",
    element: (
      <div>
        <h1>Baxa</h1>
      </div>
    ),
  },
];

export default routes;
