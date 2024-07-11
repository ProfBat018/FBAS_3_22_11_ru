import React from "react";

export default function Navbar({ goToHome, goToContact, goToAbout }) {
  // props - свойства, которые передаются в компонент
  return (
    <nav class="flex items-center justify-between flex-wrap bg-gray-800 p-6">
      <ul class="flex items-center flex-shrink-0 text-white mr-6">
        <li class="mr-3">
          <a
            onClick={goToHome}
            class="text-white
                hover:text-gray-300"
            href="#"
          >
            Home
          </a>
        </li>
        <li class="mr-3">
          <a
            onClick={goToAbout}
            class="text-white
                hover:text-gray-300"
            href="#"
          >
            About
          </a>
        </li>
        <li class="mr-3">
          <a
            onClick={goToContact}
            class="text-white
                hover:text-gray-300"
            href="#"
          >
            Contact
          </a>
        </li>
      </ul>
    </nav>
  );
}
