import React from "react";
import { Router, Route, Link, Switch } from "react-router-dom";

import { history, Role } from "@/_helpers";
import { authenticationService } from "@/_services";
import { PrivateRoute, Layout } from "@/_components";
import { HomePage } from "@/HomePage";
import { LoginPage } from "@/LoginPage";

class App extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      currentUser: null,
      isAdmin: false,
    };
  }

  componentDidMount() {
    authenticationService.currentUser.subscribe((x) =>
      this.setState({
        currentUser: x,
        isAdmin: x && x.role === Role.Admin,
      })
    );
  }

  logout() {
    authenticationService.logout();
    history.push("/login");
  }

  render() {
    const { currentUser, isAdmin } = this.state;
    return (
      <Router history={history}>
        <div>
          <Switch>
                    <PrivateRoute
                      exact
                      path="/"
                      roles={[Role.Admin, Role.StarUser, Role.FilmUser]}
                      component={HomePage}
                    />
                    <PrivateRoute
                      exact
                      path="/stars"
                      roles={[Role.Admin, Role.StarUser]}
                      component={HomePage}
                    />
                    <PrivateRoute
                      path="/filmdetails"
                      roles={[Role.Admin, Role.FilmUser]}
                      component={HomePage}
                    />
                    <Route path="/login" component={LoginPage} />
                  </Switch>
        </div>
      </Router>
    );
  }
}

export { App };
