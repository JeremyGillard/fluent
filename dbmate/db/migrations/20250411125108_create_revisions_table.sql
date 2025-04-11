-- migrate:up
create table if not exists revisions (
  id serial primary key,
  revision_date timestamptz not null default now(),
  translation_id integer not null references translations(id),
  scucceded boolean not null
)

-- migrate:down
drop table if exists revisions;
