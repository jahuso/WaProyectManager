Feature: Project

@Project
Scenario Outline: Validar Projecto
	Given Tengo el listado de Proyectos
	And Tengo el tipo de Projecto escogido $<Tipo>
	When Lo Valido
	Then El resultado debe ser Verdadero


Examples:
| Tipo       |
| Monografia |
| No Valido   | 
