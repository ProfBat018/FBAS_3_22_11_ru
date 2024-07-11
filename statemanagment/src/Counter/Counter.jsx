import React from "react";
import Button from "@mui/material/Button";
import { useSelector, useDispatch } from "react-redux";
import { decrement, increment, selectCount } from "../Counter/CounterSlice";

export default function Counter() {
  const count = useSelector(selectCount);
  const dispatch = useDispatch();

  return (
    <div>
      <h1>{count}</h1>
      <Button onClick={() => dispatch(increment())}>Increment</Button>
      <Button onClick={() => dispatch(decrement())}>Decrement</Button>
    </div>
  );
}
