import React from "react";

export default function GreenBtn() {
  return (
    <div class="flex min-h-screen w-full items-center justify-center bg-gray-100">
      <button class="group relative h-12 w-48 overflow-hidden rounded-2xl bg-green-500 text-lg font-bold text-white">
        Hover me!
        <div class="absolute inset-0 h-full w-full scale-0 rounded-2xl transition-all duration-300 group-hover:scale-100 group-hover:bg-white/30"></div>
      </button>
    </div>
  );
}
