import React, { Component } from 'react';
import  Demo  from './components/Demo';
import { BrowserRouter ,Route,Switch } from 'react-router-dom';
import { Nav, Button } from 'react-bootstrap';
import {Edit} from './components/Edit'


export default class App extends Component {
  static displayName = App.name;

    render() {
    return (
        <>
            <BrowserRouter>
                <div className="container">
                    <Switch>
                        <Route path='/' component={Demo} exact/>
                    </Switch>
                </div>
            </BrowserRouter>
            <Button variant="warning">Click ME only</Button>
            <button variant="primary">Click Me Hard</button>
            <Demo/>
        </>
    );
  }
}
