import React from 'react';
import {
  TEModal,
  TEModalDialog,
  TEModalContent,
  TEModalHeader,
  TEModalBody,
  TEModalFooter,
  TERipple
} from "tw-elements-react";

function Modal(props) {
  const { show, setShow } = props; // Destructure props to get show and setShow

  return (
    <div>
      <TEModal show={show} setShow={setShow}>
        <TEModalDialog>
          <TEModalContent>
            <TEModalHeader>
              <h5 className="text-xl font-medium leading-normal text-neutral-800 dark:text-neutral-200">
                {props.title}
              </h5>
              <button
                type="button"
                className="box-content rounded-none border-none hover:no-underline hover:opacity-75 focus:opacity-100 focus:shadow-none focus:outline-none"
                onClick={() => setShow(false)}
                aria-label="Close"
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth="1.5"
                  stroke="currentColor"
                  className="h-6 w-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M6 18L18 6M6 6l12 12"
                  />
                </svg>
              </button>
            </TEModalHeader>
            <TEModalBody>{props.body}</TEModalBody>
            <TEModalFooter>
              <TERipple rippleColor="light">
                <button
                  type="button"
                  className="inline-block rounded bg-primary-100 px-6 pb-2 pt-2.5 text-xs font-medium uppercase leading-normal text-primary-700 transition duration-150 ease-in-out hover:bg-primary-accent-100 focus:bg-primary-accent-100 focus:outline-none focus:ring-0 active:bg-primary-accent-200"
                  onClick={() => setShow(false)}
                >
                  Close
                </button>
              </TERipple>
              {/* Additional buttons can be added here */}
            </TEModalFooter>
          </TEModalContent>
        </TEModalDialog>
      </TEModal>
    </div>
  );
}

export default Modal;
