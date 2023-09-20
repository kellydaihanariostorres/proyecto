// ModalBodegas.jsx
import React, { useState, useEffect } from 'react';
import { Modal, Button, Form } from 'react-bootstrap'; // Asegúrate de haber importado Bootstrap o ajusta esto según tu configuración.

const ModalBodegas = ({ show, onHide, onSave, bodega, operation }) => {
  const [nombre, setNombre] = useState('');
  const [estado, setEstado] = useState('');
  const [direccion, setDireccion] = useState('');
  const [ciudad, setCiudad] = useState('');

  useEffect(() => {
    if (bodega && operation === 'edit') {
      setNombre(bodega.nombre);
      setEstado(bodega.estado);
      setDireccion(bodega.direccion);
      setCiudad(bodega.ciudad);
    } else {
      setNombre('');
      setEstado('');
      setDireccion('');
      setCiudad('');
    }
  }, [bodega, operation]);

  const handleSave = () => {
    const nuevaBodega = {
      nombre,
      estado,
      direccion,
      ciudad,
    };

    onSave(nuevaBodega);
    onHide();
  };

  return (
    <Modal show={show} onHide={onHide}>
      <Modal.Header closeButton>
        <Modal.Title>{operation === 'edit' ? 'Editar Bodega' : 'Agregar Bodega'}</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form>
          <Form.Group controlId="nombre">
            <Form.Label>Nombre</Form.Label>
            <Form.Control type="text" placeholder="Nombre" value={nombre} onChange={(e) => setNombre(e.target.value)} />
          </Form.Group>
          <Form.Group controlId="estado">
            <Form.Label>Estado</Form.Label>
            <Form.Control type="text" placeholder="Estado" value={estado} onChange={(e) => setEstado(e.target.value)} />
          </Form.Group>
          <Form.Group controlId="direccion">
            <Form.Label>Dirección</Form.Label>
            <Form.Control type="text" placeholder="Dirección" value={direccion} onChange={(e) => setDireccion(e.target.value)} />
          </Form.Group>
          <Form.Group controlId="ciudad">
            <Form.Label>Ciudad</Form.Label>
            <Form.Control type="text" placeholder="Ciudad" value={ciudad} onChange={(e) => setCiudad(e.target.value)} />
          </Form.Group>
        </Form>
      </Modal.Body>
      <Modal.Footer>
        <Button variant="secondary" onClick={onHide}>
          Cerrar
        </Button>
        <Button variant="primary" onClick={handleSave}>
          Guardar
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default ModalBodegas;
