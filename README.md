# OrderModule-DDD

This repo was created for the Domain Driven Design instance. An order module was used on the basis of the project and an example was created around this module.

## What is DDD

It is a software development approach that has emerged to ensure that ever-changing business rules are successfully applied to software projects in an orderly fashion.

With this approach, permanent solutions can be developed for the continuity of the software development stages or the live projects, and for the basic problems that are constantly experienced.

### Ubiquitous Language

Ubiquitous Language is the common language that enables communication between the software team and Domain Expert.

- Everything must have a definition: All definitions, terms and methodologies used within the domain should be clearly understandable.

- Details should be on the agenda: Attention should be paid to details and no open points should be left.

- The language used should be constantly improved.

- The examples used should be concrete.

- It should clearly explain the purpose of the domain.

### Bounded Context - Context Mapping

It is the base principle in DDD. It is a structure that is separated from each other and has definite boundaries.

- A domain can contain more than one subdomain. For example, the order domain may contain subdomains such as user, customer, product, stock.

- They should be internally consistent and whole. Everything required for each domain and subdomain must be within its borders.

- When creating a bounded context, a document related to that domain must be created. All terminology should be clear for the domain specified in this document, which is defined as Domain Specific Language.

- Bounded Contexts can communicate with each other within certain rules. This should be done by minimizing dependency.

- The intersection and communication architecture of Bounded Contexts is called Context Mapping.

### Entity

They are objects that have an identity. There may be objects saved in the database with unique id information. BaseEntity falls into this class.

### Value Object

They are objects that do not have an identity. It can be defined as DTOs that are used in different places and contain the information of more than one entity.

### Aggregate Root

### Services

It is the structure used for business rules and validation processes.

### Repository

It is used to perform Aggregate Root and Database communication with the specified rules.

### Layered Architecture

DDD has a 4-tier architecture. These layers are; domain, application, infrastructure and presentation layers.