import React, { useEffect, useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { Row, Col, Form, Button, Alert } from "react-bootstrap";
import { useDispatch } from 'react-redux'
import api from '../store/api-service'
import logo from '../assets/images/zorya_logo.png';
const Signup = () => {
    const module = 'user';
    const navigate = useNavigate();
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [userName, setUserName] = useState("");
    const [email, setEmail] = useState("");
    const [phoneNumber, setPhoneNumber] = useState("");
    const [password, setPassword] = useState("");
    const [confirmPassword, setConfirmPassword] = useState("");
    const [notice, setNotice] = useState("");

    const dispatch = useDispatch();
    const [patientRole, setPatientRole] = useState({});
    useEffect(() => {
        const link = document.createElement('link');
        link.rel = 'stylesheet';
        link.type = 'text/css';
        link.href = '/static/theme/cyan/theme.css';
        link.id = 'theme-link';

        const existingLink = document.getElementById('theme-link');
        if (existingLink) {
            existingLink.parentNode.removeChild(existingLink);
        }

        document.head.appendChild(link);

        return () => {
            const existing = document.getElementById('theme-link');
            if (existing) {
                existing.parentNode.removeChild(existing);
            }
        };
    }, []);

    // useEffect(() => {
    //     const baseFilter = {
    //             name: 'name',
    //             value: 'Patient'
    //         };
    //         const pageOptions = {
    //             recordPerPage: 0,
    //             searchCondition: baseFilter
    //         };
            
    //         api.getData({ module: 'role', data: pageOptions }).then((response) => {
    //             if (response?.data?.items?.length > 0) {
    //                 setPatientRole(response.data.items[0]);
    //             }                            
    //         })
    // },[]);
    

    const signupWithUsernameAndPassword = async (e) => {
        e.preventDefault();

        // Validation
        if (!firstName.trim()) {
            setNotice("First Name is required.");
            return;
        }
        if (!lastName.trim()) {
            setNotice("Last Name is required.");
            return;
        }
        if (!userName.trim()) {
            setNotice("Username is required.");
            return;
        }
        if (!email.trim()) {
            setNotice("Email is required.");
            return;
        }
        if (!password.trim()) {
            setNotice("Password is required.");
            return;
        }
        if (password !== confirmPassword) {
            setNotice("Passwords don't match. Please try again.");
            return;
        }

        try {
            await api.registerUser({ 
                module: 'user', 
                data: { 
                    firstName: firstName.trim(),
                    lastName: lastName.trim(),
                    userName: userName.trim(),
                    email: email.trim(),
                    phoneNumber: phoneNumber.trim(),
                    password: password, 
                    // roles: [patientRole], 
                    // privileges: patientRole?.privileges 
                } 
            });
            navigate("/");
        } catch (error) {
            setNotice("Sorry, something went wrong. Please try again.");
            console.error("Signup error:", error);
        }
    };

    return (
        <div className="app-login app-container app-theme-login-bg" style={{ width: '100%', minHeight: '100vh', padding: '20px' }}>
            <div className="app-container d-flex align-items-center justify-content-center" style={{ width: '100%', minHeight: 'calc(100vh - 40px)' }}>
                <div className="card shadow-lg border-0" style={{ width: '95%', maxWidth: '1200px', minHeight: '90vh' }}>
                    <div className="card-body p-4 p-md-5" style={{ height: '100%', display: 'flex', flexDirection: 'column' }}>
                        <div className="app-logo text-center mb-4">
                            <img src={logo} alt='logo' />
                            <h3 className="m-4"><strong>PATHLAB SOFTWARE</strong></h3>
                        </div>

                        <h2 className="mb-4 text-center">
                            <span className="d-block">Patient Sign Up</span>
                        </h2>

                        <Form onSubmit={(e) => signupWithUsernameAndPassword(e)} className="flex-grow-1 d-flex flex-column">
                            <Row className="flex-grow-1">
                                {"" !== notice &&
                                    <Col md={12} className="mt-2">
                                        <Alert variant="warning">{notice}</Alert>
                                    </Col>
                                }
                                <Col md={12} className="mt-2">
                                    <div className="text-muted small">Only patients can register.</div>
                                </Col>
                                <Col md={6} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='firstName'>First Name</Form.Label>
                                        <Form.Control
                                            type="text"
                                            id="firstName"
                                            placeholder="First Name"
                                            value={firstName}
                                            onChange={(e) => setFirstName(e.target.value)}
                                            required
                                        />
                                    </Form.Group>
                                </Col>
                                <Col md={6} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='lastName'>Last Name</Form.Label>
                                        <Form.Control
                                            type="text"
                                            id="lastName"
                                            placeholder="Last Name"
                                            value={lastName}
                                            onChange={(e) => setLastName(e.target.value)}
                                            required
                                        />
                                    </Form.Group>
                                </Col>
                                <Col md={12} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='userName'>Username</Form.Label>
                                        <Form.Control
                                            type="text"
                                            id="userName"
                                            placeholder="Username"
                                            value={userName}
                                            onChange={(e) => setUserName(e.target.value)}
                                            required
                                        />
                                    </Form.Group>
                                </Col>
                                <Col md={12} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='signupEmail'>Email</Form.Label>
                                        <Form.Control
                                            type="email"
                                            id="signupEmail"
                                            placeholder="name@example.com"
                                            value={email}
                                            onChange={(e) => setEmail(e.target.value)}
                                            required
                                        />
                                    </Form.Group>
                                </Col>
                                <Col md={12} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='phoneNumber'>Phone Number</Form.Label>
                                        <Form.Control
                                            type="tel"
                                            id="phoneNumber"
                                            placeholder="Phone Number"
                                            value={phoneNumber}
                                            onChange={(e) => setPhoneNumber(e.target.value)}
                                        />
                                    </Form.Group>
                                </Col>
                                <Col md={12} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='signupPassword'>Password</Form.Label>
                                        <Form.Control
                                            type="password"
                                            id="signupPassword"
                                            placeholder="Password"
                                            value={password}
                                            onChange={(e) => setPassword(e.target.value)}
                                            required
                                        />
                                    </Form.Group>
                                </Col>
                                <Col md={12} className="mt-2">
                                    <Form.Group className="position-relative">
                                        <Form.Label htmlFor='confirmPassword'>Confirm Password</Form.Label>
                                        <Form.Control
                                            type="password"
                                            id="confirmPassword"
                                            placeholder="Confirm Password"
                                            value={confirmPassword}
                                            onChange={(e) => setConfirmPassword(e.target.value)}
                                            required
                                        />
                                    </Form.Group>
                                </Col>

                                <Col md={12} className="mt-4 mb-2">
                                    <Row className="g-2">
                                        <Col md={6}>
                                            <Link to={'/login'} className="btn-wide btn-pill btn-shadow btn-hover-shine btn btn-secondary btn-lg w-100">Back to Login</Link>
                                        </Col>
                                        <Col md={6}>
                                            <Button
                                                variant="contained"
                                                className="btn-wide btn-pill btn-shadow btn-hover-shine btn btn-primary btn-lg w-100"
                                                type="submit"
                                            >
                                                Sign Up
                                            </Button>
                                        </Col>
                                    </Row>
                                </Col>
                            </Row>
                        </Form>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Signup