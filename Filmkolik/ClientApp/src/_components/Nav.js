import React from "react";
import { authenticationService} from "@/_services";
import { Link } from "react-router-dom";

function Nav() {
  const logout = () => {
    authenticationService.logout();
  };
  return (
    <div>
      <nav className="navbar navbar-expand navbar-dark bg-dark">
        <div className="navbar-brand">Filmkolik</div>
        {/* <div className="navbar-nav">
          <Link to="/" className="nav-item nav-link">
            Home
          </Link>
          <a onClick={logout} className="nav-item nav-link">
            Logout
          </a>
        </div> */}
        <ul className="navbar-nav ml-auto">
          <li className="nav-item">
          <Link to="/" className="nav-item nav-link">
            Home
          </Link>
          </li>
          <li className="navbar-nav ml-auto">
          <a onClick={logout} className="nav-item nav-link">
            Logout
          </a>
          </li>
        </ul>
      </nav>
    </div>
  );
}

export { Nav };
