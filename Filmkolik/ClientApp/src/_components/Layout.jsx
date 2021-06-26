import React from "react";
import { Nav } from "@/_components";

function Layout({ children, ...props }) {
  return (
    <div>
      <Nav />
      <div className="jumbotron">
        <div className="container">
          <div className="row">
            {children}
          </div>
        </div>
      </div>
    </div>
  );
}
export { Layout };
