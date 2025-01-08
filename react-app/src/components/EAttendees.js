import React, { useState, useEffect } from "react";
import { connect } from "react-redux";
import * as actions from "../actions/eAttendee";

const EAttendees = (props) => {
    const [x, setX] = useState(0)

    return (<div>form EAttendees</div>);
}

const mapStateToProps = state => {
    return {
        eAttendeeList: state.eAttendee.list
    }
}

const mapActionToProps = {
    fetchAllEAttendees: actions.fetchAll
}

export default connect()(EAttendees);